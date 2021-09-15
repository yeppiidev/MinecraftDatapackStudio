using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinecraftDatapackStudio.Dialogs {
    public partial class SettingsDialog : Form {
        public SettingsDialog() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            applyBtn.Enabled = false;
        }
    }
}
