using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftDatapackStudio.Dialogs
{
    public partial class WelcomeDialog : Form
    {
        public WelcomeDialog()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            newsBrowser.Load("https://.github.io/");
        }

        private void Close(object sender, EventArgs e) {
            Close();
        }

        private void newProject_Click(object sender, EventArgs e)
        {
            Close();

            new NewProjectDialog().Show(MainForm.Context);
        }
    }
}
