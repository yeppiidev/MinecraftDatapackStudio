using System;
using System.Windows.Forms;

namespace MinecraftDatapackStudio {
    partial class AboutForm : Form {
        public AboutForm() {
            InitializeComponent();
        }

        private void closeDialog_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
