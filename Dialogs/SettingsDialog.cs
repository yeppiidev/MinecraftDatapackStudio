using MinecraftDatapackStudio.Data;
using Newtonsoft.Json;
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
        public AppPreferences preferences;

        public SettingsDialog() {
            InitializeComponent();
        }

        private void OnFormLoad(object sender, EventArgs e) {
            applyBtn.Enabled = false;
            fontPicker.Apply += OnFontApply;
        }

        private void OnFontApply(object sender, EventArgs e) {
            fontTextBox.Text = fontPicker.Font.Name;
        }

        private void Editor_Click(object sender, EventArgs e) {

        }

        private void EditorSettings_Enter(object sender, EventArgs e) {

        }

        private void fontPickerLbl_Click(object sender, EventArgs e) {

        }

        private void chooseFontBtn_Click(object sender, EventArgs e) {
            fontPicker.ShowDialog();
        }

        private void applyBtn_Click(object sender, EventArgs e) {
            
        }

        public void ApplySettings() {
            preferences = new AppPreferences() {
                editor = new Editor() {
                    Font = new Font(fontTextBox.Text, (float)fontSizeCounter.Value),
                    FontSize = (int)fontSizeCounter.Value,
                    Theme = colorSchemePicker.SelectedItem.ToString()
                }
            };

            string settingsJson = JsonConvert.SerializeObject(preferences);

            MessageBox.Show(settingsJson);

            /*Utilities.PutConfig("SettingsJSON", settingsJson);*/
        }
    }
}
