using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MinecraftDatapackStudio.Dialogs {
    public partial class OpenProjectDialog : Form {
        public string MinecraftPath { get; set; }
        public string DatapackName { get; set; }
        public string WorldName { get; set; }
        public string CurrentWorldPath { get; set; }
        public string ProjectFullPath { get; set; }

        public OpenProjectDialog(string minecraftPath) {
            InitializeComponent();

            MinecraftPath = minecraftPath;
        }

        private bool CheckIfProjectExists() {
            return false;
        }

        private void OpenProject(object sender, EventArgs e) {
            DatapackName = datapacksList.SelectedItem.ToString();
            WorldName = worldsList.SelectedItem.ToString();

            ProjectFullPath = Path.Combine(CurrentWorldPath, "datapacks", DatapackName);
        }

        private void OnFormLoad(object sender, EventArgs e) {
            string[] worlds = Directory.GetDirectories(MinecraftPath + "/saves");

            worldsList.Items.Clear();
            foreach (string world in worlds) {
                worldsList.Items.Add(world.Replace(MinecraftPath + "/saves", "").Replace("\\", ""));
            }
        }

        private void OnSelectionChanged(object sender, EventArgs e) {
            datapacksList.Items.Clear();

            try {
                string worldDir = Path.Combine(MinecraftPath, "saves", worldsList.SelectedItem.ToString(), "datapacks");

                if (!Directory.EnumerateFileSystemEntries(worldDir).Any()) {
                    datapacksList.Items.Add("No datapacks available in this world");
                    datapacksList.SelectedIndex = 0;
                    openButton.Enabled = false;

                    return;
                }

                string[] datapacks = Directory.GetDirectories(worldDir);

                foreach (string datapack in datapacks) {
                    datapacksList.Items.Add(datapack.Replace(worldDir, "").Replace("\\", ""));
                    datapacksList.SelectedIndex++;
                }

                CurrentWorldPath = Path.Combine(MinecraftPath, "saves", worldsList.SelectedItem.ToString());
                openButton.Enabled = true;
            } catch (Exception) {
                datapacksList.Items.Add("Invalid world (Doesnt contain datapacks folder)");
                datapacksList.SelectedIndex = 0;

                openButton.Enabled = false;
            }
        }
    }
}
