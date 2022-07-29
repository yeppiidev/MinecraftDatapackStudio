using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CefSharp;
using MinecraftDatapackStudio.Constants;
using MinecraftDatapackStudio.Data;
using MinecraftDatapackStudio.Data.JSONContainers;
using MinecraftDatapackStudio.Dialogs;
using MinecraftDatapackStudio.Theme;
using Newtonsoft.Json;
using ScintillaNET;

namespace MinecraftDatapackStudio {
    public partial class MainForm : Form {
        private int maxLineNumberCharLength;
        private string previousName;

        private static string keywords = "execute gamemode summon schedule say give item replace from with run kill at as";
        private static string selectors = "@a @e @r @s @p";

        private SaveFileDialog saveFileDialog;

        public static string packInfoJSON;
        public static string activeFile;
        public static string CurrentProjectRootDirectory;
        public static string DefaultMinecraftFolder;
        public static string CurrentWorldName;
        public static string CurrentWorldPath;

        public static DatapackInfo currentPack;

        public static MainForm Context;
        public static AppPreferences preferences;

        public MainForm() {
            InitializeComponent();

            currentPack = new DatapackInfo();
            saveFileDialog = new SaveFileDialog();
            Context = this;

            DefaultMinecraftFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");
            whatsNewBrowser.FrameLoadEnd += FrameLoadEnd;
        }

        public static void LoadConfig() {
            try {
                string settings = Properties.Settings.Default["SettingsJSON"].ToString();
                if (settings != null && settings != "") {
                    preferences = JsonConvert.DeserializeObject<AppPreferences>(settings);

                    switch (preferences.Editor.Theme) {
                        case "Default Dark":
                            MainForm.Context.ChangeEditorThemes(new DarkColorScheme());
                            break;
                        case "Default Light":
                            MainForm.Context.ChangeEditorThemes(new LightColorScheme());
                            break;
                        default:
                            MainForm.Context.ChangeEditorThemes(new DarkColorScheme());
                            break;
                    }

                    if (Global.MinecraftPath != preferences.FilePaths.MinecraftInstallationDirectory && preferences.FilePaths.MinecraftInstallationDirectory != "" && preferences.FilePaths.MinecraftInstallationDirectory != null)
                        Global.MinecraftPath = preferences.FilePaths.MinecraftInstallationDirectory;
                }
            } catch (Exception) {
            }
        }
        private void FrameLoadEnd(object sender, FrameLoadEndEventArgs e) {
            if (e.Frame.IsMain) {
                e.Browser.MainFrame.ExecuteJavaScriptAsync("document.body.style.overflow = 'hidden'");
            }
        }

        public void ChangeEditorTheme(ColorScheme scheme, ref Scintilla control) {
            control.StyleResetDefault();
            control.CaretForeColor = scheme.Editor.CaretForeColor;
            control.Styles[Style.Default].Font = preferences.Editor.Font.Name;
            control.Styles[Style.Default].Size = (int) preferences.Editor.Font.Size;
            control.Styles[Style.Default].ForeColor = scheme.Editor.ForeColor;
            control.Styles[Style.Default].BackColor = scheme.Editor.BackColor;
            control.StyleClearAll();

            control.Margins[0].BackColor = scheme.Editor.BackColor;
            control.Markers[0].SetBackColor(scheme.Editor.BackColor);
            control.Styles[Style.LineNumber].BackColor = scheme.Editor.MarginBackColor;

            control.Styles[Style.Python.CommentLine].ForeColor = scheme.CommentLine.ForeColor; // Green
            control.Styles[Style.Python.Word].ForeColor = scheme.Word.ForeColor;
            control.Styles[Style.Python.Word2].ForeColor = scheme.Word2.ForeColor;
            control.Styles[Style.Python.String].ForeColor = scheme.String.ForeColor;
        }

        public void ChangeEditorThemes(ColorScheme scheme) {
            foreach (Control tabControl in editorTabs.Controls) {
                if (tabControl.Controls[0] is Scintilla) {
                    Scintilla control = (Scintilla) tabControl.Controls[0];

                    ChangeEditorTheme(scheme, ref control);
                }
            }
        }

        private void OnFormLoad(object sender, EventArgs e) {
            LoadConfig();
            whatsNewBrowser.Load("https://yeppiidev.github.io/MinecraftDatapackStudio/CHANGELOG.html");
        }

        private void OnFormShown(object sender, EventArgs e) {
            // WIP
            editorToolStripMenuItem.Enabled = false;
            projectToolStripMenuItem.Enabled = false;
        }

        private void ShowNewProjectDialog(object sender, EventArgs e) {
            new NewProjectDialog().ShowDialog();
        }

        public void AddTabPage() {
            editorToolStripMenuItem.Enabled = true;

            TabPage newPage = new TabPage("untitled.mcfunction");
            Scintilla control = new Scintilla() {
                Dock = DockStyle.Fill,
            };

            SetupEditor(ref control);

            newPage.Controls.Add(control);
            editorTabs.TabPages.Add(newPage);

            editorTabs.SelectedTab = newPage;

            if (!(editorTabs.SelectedTab.Controls[0] is Scintilla)) {
                editorTabs.TabPages.RemoveAt(editorTabs.SelectedIndex);
            }

        }

        private void SetupEditor(ref Scintilla control) {
            control.Lexer = Lexer.Null;

            control.AutoCDropRestOfWord = true;
            control.AutoCIgnoreCase = true;
            control.AutoCMaxHeight = 9;
            control.BiDirectionality = BiDirectionalDisplayType.Disabled;
            control.BorderStyle = BorderStyle.FixedSingle;
            control.CaretStyle = CaretStyle.Block;
            control.Dock = DockStyle.Fill;
            control.EdgeColor = Color.DarkGray;
            control.Font = new Font("Consolas", 9F);
            control.Location = new Point(3, 3);
            control.MultipleSelection = true;
            control.Name = "editor" + editorTabs.TabPages.Count;
            control.ScrollWidth = 140;
            control.Size = new Size(560, 368);
            control.TabIndents = true;
            control.TabIndex = 0;
            control.Text = TemplateTexts.MCFunction.Header;
            control.UseRightToLeftReadingLayout = false;
            control.WrapMode = WrapMode.None;
            control.CharAdded += OnEditorCharAdd;
            control.KeyDown += OnEditorKeyDown;
            control.TextChanged += OnEditorTextChange;

            control.Lexer = Lexer.Python;

            ChangeEditorTheme(new DarkColorScheme(), ref control);

            control.Margins[0].Width = 16;

            control.SetKeywords(0, keywords);
            control.SetKeywords(1, selectors);
        }


        private void OnEditorTextChange(object sender, EventArgs e) {
            // Did the number of characters in the line number display change?
            // i.e. nnn VS nn, or nnnn VS nn, etc...
            var maxLineNumberCharLength = ((Scintilla) sender).Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            ((Scintilla) sender).Margins[0].Width = ((Scintilla) sender).TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;
        }

        private void OnEditorKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space && e.Control) {
                e.SuppressKeyPress = true;
                // Find the word start
                var currentPos = ((Scintilla) sender).CurrentPosition;
                var wordStartPos = ((Scintilla) sender).WordStartPosition(currentPos, true);

                // Display the autocompletion list
                var lenEntered = currentPos - wordStartPos;
                if (lenEntered > 0) {
                    if (!((Scintilla) sender).AutoCActive)
                        ((Scintilla) sender).AutoCShow(lenEntered, keywords);
                }
            }

            if (!editorTabs.SelectedTab.Text.EndsWith("*")) {
                string oldtext = editorTabs.SelectedTab.Text;

                editorTabs.SelectedTab.Text = "";
                editorTabs.SelectedTab.Text = oldtext + "*";
            }
        }

        private void OnEditorCharAdd(object sender, CharAddedEventArgs e) {
            // Find the word start
            var currentPos = ((Scintilla) sender).CurrentPosition;
            var wordStartPos = ((Scintilla) sender).WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0) {
                if (!((Scintilla) sender).AutoCActive)
                    ((Scintilla) sender).AutoCShow(lenEntered, keywords);
            }
        }

        public static bool PackCreationFinished(string json, string minecraftFolder, string worldName, DatapackInfo packInfo) {
            packInfoJSON = json;

            currentPack = packInfo;

            string projectFolder = Path.Combine(minecraftFolder, worldName, "datapacks", packInfo.packId);
            if (Directory.Exists(projectFolder)) {
                DialogResult dialogResult = MessageBox.Show(null, "Datapack '" + packInfo.packId + "' already exists in the world '" + worldName + "'. Overwrite this pack? (The datapack will be deleted and a new one will be generated in place of it)", "Datapack already exists", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    Directory.Delete(projectFolder);
                    CreateDatapackRoot(projectFolder, packInfo.packId, json);

                    CurrentWorldName = worldName;
                    return true;
                } else {
                    return false;
                }
            } else {
                CreateDatapackRoot(projectFolder, packInfo.packId, json);
                CurrentWorldName = worldName;
            }

            Context.editorTabs.TabPages.Clear();
            MainForm.Context.projectToolStripMenuItem.Enabled = true;

            return true;
        }

        private static void CreateDatapackRoot(string path, string packName, string mcmeta) {
            FunctionTag load_json = new FunctionTag();
            FunctionTag tick_json = new FunctionTag();

            load_json.values.Add($"{packName}:load");
            tick_json.values.Add($"{packName}:tick");

            Directory.CreateDirectory(path);

            Directory.CreateDirectory(path + "/data");
            Directory.CreateDirectory(path + "/data/minecraft");
            Directory.CreateDirectory(path + "/data/minecraft/tags");
            Directory.CreateDirectory(path + "/data/minecraft/tags/functions");
            Directory.CreateDirectory(path + "/data/" + packName);
            Directory.CreateDirectory(path + "/data/" + packName + "/");
            Directory.CreateDirectory(path + "/data/" + packName + "/functions");

            Utilities.WriteFile(path + "/pack.mcmeta", mcmeta);

            Utilities.WriteJson(path + "/data/minecraft/tags/functions/load.json", load_json);
            Utilities.WriteJson(path + "/data/minecraft/tags/functions/tick.json", tick_json);

            Utilities.WriteFile(path + "/data/" + packName + "/functions/tick.mcfunction", TemplateTexts.MCFunction.TickFunctionHeader);
            Utilities.WriteFile(path + "/data/" + packName + "/functions/load.mcfunction", TemplateTexts.MCFunction.LoadFunctionHeader);

            ListDirectory(Context.projectFileTree, path);
        }

        private static void ListDirectory(TreeView treeView, string path) {
            try {
                treeView.Nodes.Clear();

                var stack = new Stack<TreeNode>();
                var rootDirectory = new DirectoryInfo(path);
                var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
                stack.Push(node);

                while (stack.Count > 0) {
                    var currentNode = stack.Pop();
                    var directoryInfo = (DirectoryInfo) currentNode.Tag;
                    foreach (var directory in directoryInfo.GetDirectories()) {
                        var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                        currentNode.Nodes.Add(childDirectoryNode);
                        stack.Push(childDirectoryNode);
                    }
                    foreach (var file in directoryInfo.GetFiles())
                        currentNode.Nodes.Add(new TreeNode(file.Name));
                }

                treeView.Nodes.Add(node);
            } catch (Exception ex) {
                MessageBox.Show(null, "Oops! I couldn't refresh the project!", "Unable to refresh the project view!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseApplication(object sender, EventArgs e) {
            Close();
            Application.Exit();
        }

        private void OnNodeClick(object sender, TreeNodeMouseClickEventArgs e) {
            try {
                if (editorTabs.TabCount == 0)
                    AddTabPage();

                string path = Path.Combine(DefaultMinecraftFolder, "saves", CurrentWorldName, "datapacks", e.Node.FullPath);

                previousName = e.Node.Text;

                editorTabs.SelectedTab.Controls[0].Text = File.ReadAllText(path);
                editorTabs.SelectedTab.Text = e.Node.Text;

                activeFile = path;

                Text = $"{e.Node.Text} - {currentPack.packId} - Minecraft Datapack Studio";
            } catch (Exception) {
            }
        }

        private void SaveOpenFile(object sender, EventArgs e) {
            Utilities.WriteFile(activeFile, editorTabs.SelectedTab.Controls[0].Text);
            editorTabs.SelectedTab.Text = editorTabs.SelectedTab.Text.Replace("*", "");
        }

        private void ShowSaveFileDialog(object sender, EventArgs e) {
            saveFileDialog.Filter = "*.*|All Files";
            saveFileDialog.DefaultExt = "*.*";
            saveFileDialog.Title = "Save File As...";
            saveFileDialog.FileOk += OnFilePicked;

            saveFileDialog.ShowDialog();
        }

        private void OnFilePicked(object sender, System.ComponentModel.CancelEventArgs e) {
            Utilities.WriteFile(saveFileDialog.FileName, editorTabs.SelectedTab.Controls[0].Text);
        }

        private void ZoomInEditor(object sender, EventArgs e) {
            ((Scintilla) editorTabs.SelectedTab.Controls[0]).ZoomIn();
        }

        private void ZoomOutEditor(object sender, EventArgs e) {
            ((Scintilla) editorTabs.SelectedTab.Controls[0]).ZoomOut();
        }

        private void CloseActiveTab(object sender, EventArgs e) {
            if (editorTabs.SelectedIndex >= 0)
                editorTabs.TabPages.RemoveAt(editorTabs.SelectedIndex);
            if (editorTabs.TabCount <= 0)
                editorToolStripMenuItem.Enabled = false;
        }

        private void OpenSite_MinecraftWiki(object sender, EventArgs e) {
            WebBrowserDialog browser = new WebBrowserDialog();

            browser.Show();
            browser.LoadURL("https://minecraft.fandom.com/");
        }

        private void OpenSite_DigMinecraft(object sender, EventArgs e) {
            WebBrowserDialog browser = new WebBrowserDialog();

            browser.Show();
            browser.LoadURL("https://digminecraft.com");
        }

        private void ShowAboutDialog(object sender, EventArgs e) {
            new AboutForm().ShowDialog();
        }

        private void ShowPreferences(object sender, EventArgs e) {
            SettingsDialog settingsDialog = new SettingsDialog();

            settingsDialog.ShowDialog();
        }

        private void RenameFile(object sender, NodeLabelEditEventArgs e) {
            if (!e.CancelEdit) {
                if (string.IsNullOrEmpty(e.Label) || string.IsNullOrWhiteSpace(e.Label)) {
                    e.CancelEdit = true;

                    return;
                }

                File.Move(Path.Combine(CurrentWorldPath, "datapacks", projectFileTree.SelectedNode.FullPath), Path.Combine(Path.GetDirectoryName(Path.Combine(CurrentWorldPath, "datapacks", projectFileTree.SelectedNode.FullPath)), e.Label));
                ListDirectory(projectFileTree, Path.Combine(CurrentWorldPath, "datapacks", currentPack.packId));
            }
        }

        private void OnProjectTreeKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.F2)
                projectFileTree.SelectedNode.BeginEdit();
            if (e.KeyCode == Keys.Escape)
                projectFileTree.SelectedNode.EndEdit(true);
        }

        private void OnRefreshProjectClicked(object sender, EventArgs e) {
            try {
                ListDirectory(projectFileTree, Path.Combine(CurrentWorldPath, "datapacks", currentPack.packId));
            } catch (Exception ex) {
                MessageBox.Show(null, "Unexpected error: " + ex.Message, "Oh No!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnDeleteItemClicked(object sender, EventArgs e) {
            string packPath = Path.Combine(CurrentWorldPath, "datapacks", (projectFileTree.SelectedNode != null ? projectFileTree.SelectedNode.FullPath : ""));

            try {
                File.Delete(packPath);

            } catch (Exception ex) {
                MessageBox.Show(null, "Oops! I coudn't delete this folder!", "Unable to delete folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ListDirectory(projectFileTree, Path.Combine(CurrentWorldPath, "datapacks", currentPack.packId));
        }

        private void OnOpenProjectToolStripItemClick(object sender, EventArgs e) {
            try {
                OpenProjectDialog openProjectDialog = new OpenProjectDialog(DefaultMinecraftFolder);

                if (openProjectDialog.ShowDialog() == DialogResult.OK) {
                    if (Directory.Exists(openProjectDialog.ProjectFullPath)) {
                        CurrentWorldName = openProjectDialog.WorldName;
                        CurrentWorldPath = Path.Combine((preferences.FilePaths.MinecraftInstallationDirectory != "" || preferences.FilePaths.MinecraftInstallationDirectory != null ? preferences.FilePaths.MinecraftInstallationDirectory : DefaultMinecraftFolder), "saves", openProjectDialog.WorldName);

                        ListDirectory(projectFileTree, openProjectDialog.ProjectFullPath);

                        PackInfo packInfo = JsonConvert.DeserializeObject<PackInfo>(File.ReadAllText(Path.Combine(openProjectDialog.ProjectFullPath, "pack.mcmeta")));
                        currentPack = new DatapackInfo() {
                            packDescription = packInfo.pack.description,
                            packId = openProjectDialog.DatapackName,
                            packVersion = packInfo.pack.pack_format
                        };

                        projectToolStripMenuItem.Enabled = true;
                        editorToolStripMenuItem.Enabled = true;

                        CurrentProjectRootDirectory = openProjectDialog.ProjectFullPath;

                        editorTabs.TabPages.Clear();
                    } else {
                        MessageBox.Show(null, "It seems like, the world/datapack you selected doesnt exist? This isn't supposed to happen! If you see this, report it to our Discord (link in the about page)", "Hmm...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            } catch (Exception ex) {
                MessageBox.Show(null, "Unexpected error: " + ex.Message, "Oh No!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnLabelEditStart(object sender, NodeLabelEditEventArgs e) {
            previousName = e.Label;
        }

        private void OnShowInExplorerClick(object sender, EventArgs e) {
            string packPath = Path.Combine(CurrentWorldPath, "datapacks", (projectFileTree.SelectedNode != null ? projectFileTree.SelectedNode.FullPath : ""));

            try {
                Process process = new Process() {
                    StartInfo = new ProcessStartInfo(packPath)
                };

                process.Start();
            } catch (Exception ex) {
                MessageBox.Show(null, "Oops! Unable to open Windows Explorer: " + packPath, "Unable to open Windows Explorer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnAddElementClick(object sender, EventArgs e) {
            try {
                AddElementDialog addElementDialog = new AddElementDialog();

                if (addElementDialog.ShowDialog() == DialogResult.OK) {
                    string packPath = Path.Combine(CurrentWorldPath, "datapacks", (projectFileTree.SelectedNode != null ? projectFileTree.SelectedNode.FullPath : ""), addElementDialog.DatapackElementName);
                    string selectedPath = Path.Combine(CurrentWorldPath, "datapacks", (projectFileTree.SelectedNode != null ? projectFileTree.SelectedNode.FullPath : ""));

                    switch (addElementDialog.DatapackElement) {
                        case DatapackElement.Function:
                            FileAttributes fileAttributes = File.GetAttributes(selectedPath);

                            if (!fileAttributes.HasFlag(FileAttributes.Directory)) {
                                selectedPath = Path.GetDirectoryName(selectedPath);
                            }

                            StreamWriter streamWriter = File.CreateText(Path.Combine(selectedPath, addElementDialog.DatapackElementName));

                            streamWriter.Write(TemplateTexts.MCFunction.Header);
                            streamWriter.Flush();
                            streamWriter.Close();

                            break;
                    }

                    ListDirectory(projectFileTree, Path.Combine(CurrentWorldPath, "datapacks", currentPack.packId));
                }
            } catch (Exception ex) {
                MessageBox.Show(null, "Unexpected error: " + ex.Message, "Oh No!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}