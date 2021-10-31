using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MinecraftDatapackStudio {
    public class Utilities {
        public Utilities() { }

        public static void PutConfig(string value) {
            Properties.Settings.Default.SettingsJSON = value;
            Properties.Settings.Default.Save();
        }

        public static bool WriteFile(string fileName, string content) {
            try {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName)) {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName)) {
                    // Add some text to file    
                    Byte[] text = new UTF8Encoding(true).GetBytes(content);
                    fs.Write(text, 0, text.Length);
                }

                return true;
            } catch (Exception Ex) {
                MessageBox.Show(Ex.ToString());
                return false;
            }
        }

        //Creating the extern function...  
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        //Creating a function that uses the API function...  
        public static bool IsConnectedToInternet() {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public static bool WriteJson(string file, object obj) {
            string json = JsonConvert.SerializeObject(obj, Formatting.Indented);

            return WriteFile(file, json);
        }
    }
}
