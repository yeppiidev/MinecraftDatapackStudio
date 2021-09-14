using CefSharp;
using MinecraftDatapackStudio.Data;
using MinecraftDatapackStudio.Data.JSONContainers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MinecraftDatapackStudio.Dialogs
{
    public partial class NewProjectDialog : Form
    {
        private List<string> versions;

        private string manifestDownloadPath = "./meta/minecraft/";
        private string manifestDownloadFile = "version_manifest.json";
        private string minecraftFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");

        public static DatapackInfo PackInfo;
        public static Dictionary<String, String> PackVersion;
        public static string PackInfoJson;

        public NewProjectDialog()
        {
            InitializeComponent();

            errorText.Hide();
            PackVersion = new Dictionary<string, string>();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        static bool FileEquals(string path1, string path2)
        {
            byte[] file1 = File.ReadAllBytes(path1);
            byte[] file2 = File.ReadAllBytes(path2);
            if (file1.Length == file2.Length)
            {
                for (int i = 0; i < file1.Length; i++)
                {
                    if (file1[i] != file2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private async void NewProjectDialog_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                try
                {
                    if (!Directory.Exists(manifestDownloadPath))
                    {
                        Directory.CreateDirectory(manifestDownloadPath);
                    }

                    if (Utilities.IsConnectedToInternet())
                    {
                        client.DownloadFileAsync(new Uri("https://api.jsonbin.io/b/613f0f129548541c29b0f5f5/1"), manifestDownloadPath + manifestDownloadFile);

                        client.DownloadFileCompleted += (object eventSender, System.ComponentModel.AsyncCompletedEventArgs completedEventArgs) =>
                        {
                            parseJson();
                        };
                    } else
                    {
                        parseJson();
                    }
                }
                catch (Exception)
                {
                    errorText.Show();
                }
            }

            string[] worlds = Directory.GetDirectories(minecraftFolder + "/saves");

            worldsList.Items.Clear();
            foreach (string world in worlds)
            {
                worldsList.Items.Add(world.Replace(minecraftFolder + "/saves", "").Replace("\\", ""));
            }
        }

        public void parseJson()
        {
            try
            {
                String json = File.ReadAllText(manifestDownloadPath + manifestDownloadFile);
                DatapackVersion datapackVersion = JsonConvert.DeserializeObject<DatapackVersion>(json);

                minecraftVersionBox.Items.Clear();

                foreach (var version in datapackVersion.versions)
                {
                    minecraftVersionBox.Items.Add(version.Key);
                    PackVersion.Add(version.Key, version.Value);
                }
            }
            catch (Exception ex)
            {
                errorText.Text = "Unable to retrieve versions!";
                errorText.Show();
            }
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (projNameBox.Text == "")
                {
                    errorText.Text = "Please fill in all the fields!";
                    errorText.Show();

                    return;
                }

                if (PackVersion.Count <= 0)
                {
                    return;
                }

                if (!PackVersion.ContainsKey(minecraftVersionBox.SelectedItem.ToString()))
                {
                    errorText.Text = "Invalid Minecraft version!";
                    errorText.Show();

                    return;
                }

                // class thats used in the ide
                PackInfo = new DatapackInfo()
                {
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
                PackInfo datapackInfo = new PackInfo()
                {
                    pack = new pack()
                    {
                        description = PackInfo.packDescription,
                        pack_format = PackInfo.packVersion
                    }
                };

                string json = JsonConvert.SerializeObject(datapackInfo, Formatting.Indented);

                if (MainForm.PackCreationFinished(json, minecraftFolder + "/saves", worldsList.Text, PackInfo.packId))
                {
                    Close();
                }
            } catch (Exception)
            {
                errorText.Text = "Unable to create project!";
                errorText.Show();
            }
        }
    }
}
