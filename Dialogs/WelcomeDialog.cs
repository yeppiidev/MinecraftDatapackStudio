using System;
using System.Windows.Forms;

namespace MinecraftDatapackStudio.Dialogs {
    public partial class WelcomeDialog : Form {
        public WelcomeDialog() {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e) {
            newsBrowser.Load("https://yeppiidev.github.io/MinecraftDatapackStudio/CHANGELOG.html");
        }

        private void Close(object sender, EventArgs e) {
            Close();
        }

        private void newProject_Click(object sender, EventArgs e) {
            Close();

            new NewProjectDialog().Show(MainForm.Context);
        }
    }
}
