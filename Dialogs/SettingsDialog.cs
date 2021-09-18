using Microsoft.WindowsAPICodePack.Dialogs;
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

            applyBtn.Enabled = false;

            fontPicker.Apply += OnFontApply;
            colorSchemePicker.SelectedIndex = 0;

            try {
                string settings = Properties.Settings.Default["SettingsJSON"].ToString();
                if (settings != null && settings != "") {
                    preferences = JsonConvert.DeserializeObject<AppPreferences>(settings);

                    fontTextBox.Text = preferences.Editor.Font.Name;
                    fontSizeCounter.Value = preferences.Editor.FontSize;
                    mcFolderPathBox.Text = preferences.FilePaths.MinecraftInstallationDirectory == "" ? MainForm.DefaultMinecraftFolder : preferences.FilePaths.MinecraftInstallationDirectory;

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
                    colorSchemePicker.SelectedItem = preferences.Editor.Theme;

                } else {
                    fontSizeCounter.Value = 14;
                    fontTextBox.Text = "Consolas";
                    string settingsJson = JsonConvert.SerializeObject(preferences);
                    Utilities.PutConfig(settingsJson);
                }
            } catch (Exception) {
            }
        }

        private void OnFormLoad(object sender, EventArgs e) {
            
        }

        private void OnFontApply(object sender, EventArgs e) {
            fontTextBox.Text = fontPicker.Font.Name;
        }

        private void OnChooseFontButtonClick(object sender, EventArgs e) {
            if (fontPicker.ShowDialog() == DialogResult.OK) {
                fontTextBox.Text = fontPicker.Font.Name;
                fontSizeCounter.Value = (decimal) fontPicker.Font.SizeInPoints;
            }
        }

        private void OnApplyButtonClick(object sender, EventArgs e) {
            ApplySettings();
        }

        public void ApplySettings() {
            preferences = new AppPreferences() {
                Editor = new Editor() {
                    Font = new Font(fontTextBox.Text, (float)fontSizeCounter.Value),
                    FontSize = (int)fontSizeCounter.Value,
                    Theme = colorSchemePicker.SelectedItem.ToString()
                },
                FilePaths = new FilePaths() {
                    MinecraftInstallationDirectory = mcFolderPathBox.Text
                }
            };

            string settingsJson = JsonConvert.SerializeObject(preferences);
            Utilities.PutConfig(settingsJson);

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

            applyBtn.Enabled = false;
        }

        private void OnColorSchemePickerSelectedItemChanged(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }

        private void OnFontSizeVounterValueChanged(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }

        private void OnFontTextBoxTextChange(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }

        private void OnOkButtonClick(object sender, EventArgs e) {
            ApplySettings();
        }

        private void ChooseMinecraftFolder(object sender, EventArgs e) {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();

            dialog.IsFolderPicker = true;
            dialog.Title = "Select where you installed Minecraft...";
            dialog.InitialDirectory = "%APPDATA%\\.minecraft";
            dialog.EnsurePathExists = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok) {
                mcFolderPathBox.Text = dialog.FileName;
            }
        }

        private void OnMinecraftFolderPathBoxTextChanged(object sender, EventArgs e) {
            applyBtn.Enabled = true;
        }
    }
}
