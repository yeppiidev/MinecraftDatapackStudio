using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MinecraftDatapackStudio.Data;
using MinecraftDatapackStudio.Data.JSONContainers;
using Newtonsoft.Json;

namespace MinecraftDatapackStudio.Dialogs {
    public partial class NewProjectDialog : Form {
        public static DatapackInfo PackInfo;
        public static Dictionary<String, String> PackVersion;
        public static string PackInfoJson;

        public NewProjectDialog() {
            InitializeComponent();

            errorText.Hide();
            PackVersion = new Dictionary<string, string>();
        }

        private void CancelClicked(object sender, EventArgs e) {
            Close();
        }

        static bool FileEquals(string path1, string path2) {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length) {
                for (int i = 0; i < file1.Length; i++) {
                    if (file1[i] != file2[i]) {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private void OnFormLoad(object sender, EventArgs e) {
            using (var client = new WebClient()) {
                try {
                    if (!Directory.Exists(Global.VersionManifestDownloadPath)) {
                        Directory.CreateDirectory(Global.VersionManifestDownloadPath);
                    }

                    if (Utilities.IsConnectedToInternet()) {
                        client.DownloadFileAsync(new Uri(Global.VersionManifestDownloadLink), Path.Combine(Global.VersionManifestDownloadPath, Global.VersionManifestDownloadFile));

                        client.DownloadFileCompleted += (object eventSender, System.ComponentModel.AsyncCompletedEventArgs completedEventArgs) => {
                            ParseJSON();
                        };
                    } else {
                        ParseJSON();
                    }
                } catch (Exception) {
                    errorText.Show();
                }
            }

            string[] worlds = Directory.GetDirectories(Path.Combine(Global.MinecraftPath, "saves"));

            worldsList.Items.Clear();
            foreach (string world in worlds) {
                worldsList.Items.Add(world.Replace(Path.Combine(Global.MinecraftPath, "saves"), "").Replace("\\", ""));
            }
        }

        public void ParseJSON() {
            try {
                String json = File.ReadAllText(Global.VersionManifestDownloadPath + Global.VersionManifestDownloadFile);
                DatapackVersion datapackVersion = JsonConvert.DeserializeObject<DatapackVersion>(json);

                minecraftVersionBox.Items.Clear();

                foreach (var version in datapackVersion.versions) {
                    minecraftVersionBox.Items.Add(version.Key);
                    PackVersion.Add(version.Key, version.Value);
                }
            } catch (Exception ex) {
                errorText.Text = $"Unable to retrieve versions: {ex.Message}";
                errorText.Show();
            }
        }

        private void CreateProject(object sender, EventArgs e) {
            try {
                if (projNameBox.Text == "") {
                    errorText.Text = "Please fill in all the fields!";
                    errorText.Show();

                    return;
                }

                if (PackVersion.Count <= 0) {
                    return;
                }

                if (!PackVersion.ContainsKey(minecraftVersionBox.SelectedItem.ToString())) {
                    errorText.Text = "Invalid Minecraft version!";
                    errorText.Show();

                    return;
                }

                // class thats used in the ide
                PackInfo = new DatapackInfo() {
                    packId = projNameBox.Text.Replace(" ", "_")
                                             .Replace("/", "")
                                             .Replace("\\", "")
                                             .Replace("\"", "")
                                             .Replace("?", "")
                                             .Replace("*", "")
                                             .Replace("<", "")
                                             .Replace(">", "")
                                             .Replace(":", "")
                                             .Replace("|", ""),
                    packDescription = projDescriptionBox.Text,
                    packVersion = Int32.Parse(PackVersion[minecraftVersionBox.SelectedItem.ToString()])
                };

                // class thats used to serialize to json
                PackInfo datapackInfo = new PackInfo() {
                    pack = new pack() {
                        description = PackInfo.packDescription,
                        pack_format = PackInfo.packVersion
                    }
                };

                string json = JsonConvert.SerializeObject(datapackInfo, Formatting.Indented);

                if (MainForm.PackCreationFinished(json, Path.Combine(Global.MinecraftPath, "saves"), worldsList.Text, PackInfo)) {
                    Close();
                }
            } catch (Exception) {
                errorText.Text = "Unable to create project!";
                errorText.Show();
            }
        }
    }
}
