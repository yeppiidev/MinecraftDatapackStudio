using MinecraftDatapackStudio.Constants;
using MinecraftDatapackStudio.Data;
using MinecraftDatapackStudio.Data.JSONContainers;
using MinecraftDatapackStudio.Dialogs;
using ScintillaNET;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MinecraftDatapackStudio
{
    public partial class MainForm : Form
    {
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

        public MainForm()
        {
            InitializeComponent();
            
            tabs = new Dictionary<TabPage, Scintilla>();
            currentPack = new DatapackInfo();
            saveFileDialog = new SaveFileDialog();
            Context = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetupEditor(ref scintilla);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewProjectDialog().ShowDialog();
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraft.fandom.com/wiki/Data_Pack");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutForm().ShowDialog();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void projectFileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        public void AddTabPage()
        {
            TabPage newPage = new TabPage("untitled.mcfunction");
            Scintilla control = new Scintilla
            {
                Dock = DockStyle.Fill
            };

            activeEditor = control;
            SetupEditor(ref control);
            newPage.Controls.Add(control);
            editorTabs.TabPages.Add(newPage);
            tabs.Add(newPage, control);
        }

        private void addFunctionToolBtn_Click(object sender, EventArgs e)
        {
            AddTabPage();
        }

        private void SetupEditor(ref Scintilla control)
        {
            control.Lexer = Lexer.Null;

            control.AutoCDropRestOfWord = true;
            control.AutoCIgnoreCase = true;
            control.AutoCMaxHeight = 9;
            control.BiDirectionality = ScintillaNET.BiDirectionalDisplayType.Disabled;
            control.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            control.CaretStyle = ScintillaNET.CaretStyle.Block;
            control.Dock = System.Windows.Forms.DockStyle.Fill;
            control.EdgeColor = System.Drawing.Color.DarkGray;
            control.Font = new System.Drawing.Font("Consolas", 9F);
            control.Location = new System.Drawing.Point(3, 3);
            control.MultipleSelection = true;
            control.Name = "editor" + editorTabs.TabPages.Count;
            control.ScrollWidth = 140;
            control.Size = new System.Drawing.Size(560, 368);
            control.TabIndents = true;
            control.TabIndex = 0;
            control.Text = TemplateTexts.MCFunction.Header;
            control.UseRightToLeftReadingLayout = false;
            control.ViewWhitespace = ScintillaNET.WhitespaceMode.VisibleAfterIndent;
            control.WrapMode = ScintillaNET.WrapMode.None;
            control.CharAdded += Control_CharAdded;
            control.KeyDown += Control_KeyDown;
            control.TextChanged += Control_TextChanged;

            control.Lexer = Lexer.Python;

            control.StyleResetDefault();
            control.Styles[Style.Default].Font = "Consolas";
            control.Styles[Style.Default].Size = 10;
            control.StyleClearAll();

            control.Styles[Style.Python.CommentLine].ForeColor = Color.DarkGreen; // Green
            control.Styles[Style.Python.Word].ForeColor = Color.Blue;
            control.Styles[Style.Python.Word2].ForeColor = Color.Blue;
            control.Styles[Style.Python.String].ForeColor = Color.Brown;

            control.Margins[0].Width = 16;

            control.SetKeywords(0, keywords);
            control.SetKeywords(1, selectors);
        }

        private void Control_TextChanged(object sender, EventArgs e)
        {
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

        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && e.Control)
            {
                e.SuppressKeyPress = true;
                // Find the word start
                var currentPos = ((Scintilla)sender).CurrentPosition;
                var wordStartPos = ((Scintilla)sender).WordStartPosition(currentPos, true);

                // Display the autocompletion list
                var lenEntered = currentPos - wordStartPos;
                if (lenEntered > 0)
                {
                    if (!((Scintilla)sender).AutoCActive)
                        ((Scintilla)sender).AutoCShow(lenEntered, keywords);
                }
            }
        }

        private void Control_CharAdded(object sender, CharAddedEventArgs e)
        {
            // Find the word start
            var currentPos = ((Scintilla)sender).CurrentPosition;
            var wordStartPos = ((Scintilla)sender).WordStartPosition(currentPos, true);

            // Display the autocompletion list
            var lenEntered = currentPos - wordStartPos;
            if (lenEntered > 0)
            {
                if (!((Scintilla)sender).AutoCActive)
                    ((Scintilla)sender).AutoCShow(lenEntered, keywords);
            }
        }

        private void functionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTabPage();
        }

        public static bool PackCreationFinished(string json, string minecraftFolder, string worldName, string projectName)
        {
            packInfoJSON = json;

            string projectFolder = minecraftFolder + "/" + worldName + "/datapacks/" + projectName;
            if (Directory.Exists(projectFolder))
            {
                DialogResult dialogResult = MessageBox.Show(null, "Datapack '" + projectName + "' already exists in the world '" + worldName + "'. Overwrite this pack? (The datapack will be deleted and a new one will be generated in place of it)", "Datapack already exists", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    Directory.Delete(projectFolder);
                    CreateDatapackRoot(projectFolder, projectName, json);

                    datapackRoot = minecraftFolder + "/" + worldName + "/datapacks";
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                CreateDatapackRoot(projectFolder, projectName, json);
                datapackRoot = minecraftFolder + "/" + worldName + "/datapacks";
            }
            return true;

        }

        private static void CreateDatapackRoot(string path, string packName, string mcmeta)
        {
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

        private static void ListDirectory(TreeView treeView, string path)
        {
            var stack = new Stack<TreeNode>();
            var rootDirectory = new DirectoryInfo(path);
            var node = new TreeNode(rootDirectory.Name) { Tag = rootDirectory };
            stack.Push(node);

            while (stack.Count > 0)
            {
                var currentNode = stack.Pop();
                var directoryInfo = (DirectoryInfo)currentNode.Tag;
                foreach (var directory in directoryInfo.GetDirectories())
                {
                    var childDirectoryNode = new TreeNode(directory.Name) { Tag = directory };
                    currentNode.Nodes.Add(childDirectoryNode);
                    stack.Push(childDirectoryNode);
                }
                foreach (var file in directoryInfo.GetFiles())
                    currentNode.Nodes.Add(new TreeNode(file.Name));
            }

            treeView.Nodes.Add(node);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void digminecraftcomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowserDialog browser = new WebBrowserDialog();

            browser.Show();
            browser.LoadURL("https://digminecraft.com");
        }

        private void projectFileTree_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            try
            {
                string path = datapackRoot + "/" + e.Node.FullPath;
                editorTabs.SelectedTab.Controls[0].Text = File.ReadAllText(path);
                editorTabs.SelectedTab.Text = e.Node.Text;

                activeFile = path;
            }
            catch (Exception) { }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilities.WriteFile(activeFile, editorTabs.SelectedTab.Controls[0].Text);
            editorTabs.SelectedTab.Text = editorTabs.SelectedTab.Text.Replace("*", "");
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            saveFileDialog.Filter = "*.*|All Files";
            saveFileDialog.DefaultExt = "*.*";
            saveFileDialog.Title = "Save File As...";
            saveFileDialog.FileOk += OnFilePicked;

            saveFileDialog.ShowDialog();
        }

        private void OnFilePicked(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Utilities.WriteFile(saveFileDialog.FileName, editorTabs.SelectedTab.Controls[0].Text);
        }

        private void zoomInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)editorTabs.SelectedTab.Controls[0]).ZoomIn();
        }

        private void zoomOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Scintilla)editorTabs.SelectedTab.Controls[0]).ZoomOut();
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(editorTabs.SelectedIndex >= 0)
                editorTabs.TabPages.RemoveAt(editorTabs.SelectedIndex);
        }

        private void minecraftWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WebBrowserDialog browser = new WebBrowserDialog();

            browser.Show();
            browser.LoadURL("https://minecraft.fandom.com/");  
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            new WelcomeDialog().ShowDialog();
        }
    }
}

