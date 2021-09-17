using MinecraftDatapackStudio.Data;
using MinecraftDatapackStudio.Properties;
using MinecraftDatapackStudio.Theme;
using Newtonsoft.Json;
using System;
using System.Drawing;
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
            colorSchemePicker.SelectedIndex = 0;

            try {
                string settings = Properties.Settings.Default["SettingsJSON"].ToString();
                if (settings != null && settings != "") {
                    preferences = JsonConvert.DeserializeObject<AppPreferences>(settings);

                    fontTextBox.Text = preferences.Editor.Font.Name;
                    fontSizeCounter.Value = preferences.Editor.FontSize;

                    if (preferences.Editor.Theme == "Default Dark") {
                        MainForm.Context.ChangeEditorThemes(new DarkColorScheme());
                    }
                } else {
                    fontSizeCounter.Value = 14;
                    fontTextBox.Text = "Consolas";
                    string settingsJson = JsonConvert.SerializeObject(preferences);
                    Utilities.PutConfig(settingsJson);
                }
            } catch (Exception) {
            }
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
            ApplySettings();
        }

        public void ApplySettings() {
            preferences = new AppPreferences() {
                Editor = new Editor() {
                    Font = new Font(fontTextBox.Text, (float)fontSizeCounter.Value),
                    FontSize = (int)fontSizeCounter.Value,
                    Theme = colorSchemePicker.SelectedItem.ToString()
                }
            };

            string settingsJson = JsonConvert.SerializeObject(preferences);
            Utilities.PutConfig(settingsJson);
            applyBtn.Enabled = false;
        }

        private void colorSchemePicker_SelectedValueChanged(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }

        private void fontSizeCounter_ValueChanged(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }

        private void fontTextBox_TextChanged(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }

        private void okBtn_Click(object sender, EventArgs e) {
            ApplySettings();
        }
    }
}
