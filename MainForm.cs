using MinecraftDatapackStudio.Constants;
using MinecraftDatapackStudio.Data;
using MinecraftDatapackStudio.Data.JSONContainers;
using MinecraftDatapackStudio.Dialogs;
using MinecraftDatapackStudio.Theme;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MinecraftDatapackStudio {
    public partial class MainForm : Form {
        private int maxLineNumberCharLength;

        private static string keywords = "execute gamemode summon schedule say give item replace from with run kill at as";
        private static string selectors = "@a @e @r @s @p";

        private Dictionary<TabPage, Scintilla> tabs;
        private Scintilla activeEditor;
        private SaveFileDialog saveFileDialog;

        public static string packInfoJSON;
        public static string activeFile;
        public static string datapackRoot;

        public static DatapackInfo currentPack;

        public static MainForm Context;

        public MainForm() {
            InitializeComponent();

            tabs = new Dictionary<TabPage, Scintilla>();
            currentPack = new DatapackInfo();
            saveFileDialog = new SaveFileDialog();
            Context = this;
        }

        public void ChangeEditorTheme(ColorScheme scheme, ref Scintilla control) {
                control.StyleResetDefault();
                control.Styles[Style.Default].Font = "Consolas";
                control.Styles[Style.Default].Size = 10;
                control.Styles[Style.Default].ForeColor = scheme.Editor.ForeColor;
                control.Styles[Style.Default].BackColor = scheme.Editor.BackColor;
                control.Styles[Style.LineNumber].ForeColor = scheme.Editor.ForeColor;
                control.Styles[Style.LineNumber].BackColor = scheme.Editor.BackColor;
                control.StyleClearAll();

                control.Styles[Style.Python.CommentLine].ForeColor = scheme.CommentLine.ForeColor; // Green
                control.Styles[Style.Python.Word].ForeColor = scheme.Word.ForeColor;
                control.Styles[Style.Python.Word2].ForeColor = scheme.Word2.ForeColor;
                control.Styles[Style.Python.String].ForeColor = scheme.String.ForeColor;
        }

        public void ChangeEditorThemes(ColorScheme scheme) {
            foreach (Control tabControl in editorTabs.Controls) {
                Scintilla control = (Scintilla) tabControl;

                control.StyleResetDefault();
                control.Styles[Style.Default].Font = "Consolas";
                control.Styles[Style.Default].Size = 10;
                control.Styles[Style.Default].ForeColor = scheme.Editor.ForeColor;
                control.Styles[Style.Default].BackColor = scheme.Editor.BackColor;
                control.StyleClearAll();

                control.Styles[Style.Python.CommentLine].ForeColor = scheme.CommentLine.ForeColor; // Green
                control.Styles[Style.Python.Word].ForeColor = scheme.Word.ForeColor;
                control.Styles[Style.Python.Word2].ForeColor = scheme.Word2.ForeColor;
                control.Styles[Style.Python.String].ForeColor = scheme.String.ForeColor;
            }
        }

        private void OnFormLoad(object sender, EventArgs e) {
            whatsNewBrowser.Load("https://yeppiidev.github.io/MinecraftDatapackStudio/CHANGELOG.html");
        }

        private void OnFormShown(object sender, EventArgs e) {
            // WIP
            editorToolStripMenuItem.Enabled = false;
        }

        private void ShowNewProjectDialog(object sender, EventArgs e) {
            new NewProjectDialog().ShowDialog();
        }

        public void AddTabPage() {
            if (!(editorTabs.SelectedTab.Controls[0] is Scintilla)) {
                editorTabs.TabPages.RemoveAt(editorTabs.SelectedIndex);
            }

            editorToolStripMenuItem.Enabled = true;

            TabPage newPage = new TabPage("untitled.mcfunction");
            Scintilla control = new Scintilla() {
                Dock = DockStyle.Fill,
            };   

            SetupEditor(ref control);

            activeEditor = control;
            newPage.Controls.Add(control);
            editorTabs.TabPages.Add(newPage);
            tabs.Add(newPage, control);

            editorTabs.SelectedTab = newPage;
        }

        private void OnAddFunctionMenuItemClick(object sender, EventArgs e) {
            AddTabPage();
        }

        private void OnAddFunctionButtonClick(object sender, EventArgs e) {
            AddTabPage();
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
            control.ViewWhitespace = WhitespaceMode.VisibleAfterIndent;
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
            var maxLineNumberCharLength = ((Scintilla)sender).Lines.Count.ToString().Length;
            if (maxLineNumberCharLength == this.maxLineNumberCharLength)
                return;

            // Calculate the width required to display the last line number
            // and include some padding for good measure.
            const int padding = 2;
            ((Scintilla)sender).Margins[0].Width = ((Scintilla)sender).TextWidth(Style.LineNumber, new string('9', maxLineNumberCharLength + 1)) + padding;
            this.maxLineNumberCharLength = maxLineNumberCharLength;

            string oldtext = editorTabs.SelectedTab.Text;

            editorTabs.SelectedTab.Text = "";
            editorTabs.SelectedTab.Text = oldtext + "*";
        }

        private void OnEditorKeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Space && e.Control) {
                e.SuppressKeyPress = true;
                // Find the word start
                var currentPos = ((Scintilla)sender).CurrentPosition;
                var wordStartPos = ((Scintilla)sender).WordStartPosition(currentPos, true);

                // Display the autocompletion list
                var lenEntered = currentPos - wordStartPos;
                if (lenEntered > 0) {
                    if (!((Scintilla)sender).AutoCActive)
                        ((Scintilla)sender).AutoCShow(lenEntered, keywords);
                }
            }
        }

        private void OnEditorCharAdd(object sender, CharAddedEventArgs e) {
            // Find the word start
            var currentPos = ((Scintilla)sender).CurrentPosition;
            var wordStartPos = ((Scintilla)sender).WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0) {
                if (!((Scintilla)sender).AutoCActive)
                    ((Scintilla)sender).AutoCShow(lenEntered, keywords);
            }
        }

        public static bool PackCreationFinished(string json, string minecraftFolder, string worldName, DatapackInfo packInfo) {
            packInfoJSON = json;

            currentPack = packInfo;

            string projectFolder = minecraftFolder + "/" + worldName + "/datapacks/" + packInfo.packId;
            if (Directory.Exists(projectFolder)) {
                DialogResult dialogResult = MessageBox.Show(null, "Datapack '" + packInfo.packId + "' already exists in the world '" + worldName + "'. Overwrite this pack? (The datapack will be deleted and a new one will be generated in place of it)", "Datapack already exists", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes) {
                    Directory.Delete(projectFolder);
                    CreateDatapackRoot(projectFolder, packInfo.packId, json);

                    datapackRoot = minecraftFolder + "/" + worldName + "/datapacks";
                    return true;
                } else {
                    return false;
                }
            } else {
                CreateDatapackRoot(projectFolder, packInfo.packId, json);
                datapackRoot = minecraftFolder + "/" + worldName + "/datapacks";
            }
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
            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0) {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories()) {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                    currentNode.Nodes.Add(new TreeNode(file.Name));
            }

            treeView.Nodes.Add(node);
        }

        private void CloseApplication(object sender, EventArgs e) {
            Close();
            Application.Exit();
        }

        private void OpenTabOnNodeClick(object sender, TreeNodeMouseClickEventArgs e) {
            try {
                string path = datapackRoot + "/" + e.Node.FullPath;
                editorTabs.SelectedTab.Controls[0].Text = File.ReadAllText(path);
                editorTabs.SelectedTab.Text = e.Node.Text;

                activeFile = path;

                Text = $"{e.Node.Text} - {currentPack.packId} - Minecraft Datapack Studio";
            } catch (Exception) { }
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
            ((Scintilla)editorTabs.SelectedTab.Controls[0]).ZoomIn();
        }

        private void ZoomOutEditor(object sender, EventArgs e) {
            ((Scintilla)editorTabs.SelectedTab.Controls[0]).ZoomOut();
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
    }
}

