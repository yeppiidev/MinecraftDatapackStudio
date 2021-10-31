using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;
using MinecraftDatapackStudio.Data;
using Newtonsoft.Json;

namespace MinecraftDatapackStudio {
    partial class AboutForm : Form {
        public string AboutInfoDownloadPath = "meta/";
        public string AboutInfoDownloadFile = "AboutInfo.json";

        public AboutInfo AboutInfo;

        public AboutForm() {
            InitializeComponent();

            LoadAboutInfo();
        }

        public void LoadAboutInfo() {
            using (var client = new WebClient()) {
                try {
                    if (!Directory.Exists(Global.AboutInfoDownloadPath)) {
                        Directory.CreateDirectory(Global.AboutInfoDownloadPath);
                    }

                    if (Utilities.IsConnectedToInternet()) {
                        client.DownloadFileAsync(new Uri(Global.AboutInfoDownloadLink), Path.Combine(Global.AboutInfoDownloadPath, Global.AboutInfoDownloadFile));

                        client.DownloadFileCompleted += (object sender, AsyncCompletedEventArgs args) => {
                            ParseAboutInfo();
                        };
                    } else {
                        ParseAboutInfo();
                    }
                } catch (Exception) {
                    errorText.Show();
                }
            }
        }

        public void ParseAboutInfo() {

            try {
                String json = File.ReadAllText(Path.Combine(Global.AboutInfoDownloadPath, Global.AboutInfoDownloadFile));
                AboutInfo = JsonConvert.DeserializeObject<AboutInfo>(json);

                contributorsList.Items.Clear();

                foreach (var contributor in AboutInfo.Contributors) {
                    contributorsList.Items.Add(contributor);
                }

                latestVersionLabelInfo.Text = AboutInfo.LatestVersion;
            } catch (Exception ex) {
                errorText.Text = $"Unable to load about info: {ex.Message}";
                errorText.Show();
            }

        }

        private void CloseDialog_Click(object sender, EventArgs e) {
            Close();
        }
    }
}
