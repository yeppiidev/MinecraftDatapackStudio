using System;
using System.IO;

namespace MinecraftDatapackStudio {
    public class Global {
        public static string MinecraftPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), ".minecraft");

        public static string AboutInfoDownloadLink = "https://raw.githubusercontent.com/yeppiidev/MinecraftDatapackStudio/main/Config/AboutInfo.json";
        public static string AboutInfoDownloadPath = "meta/";
        public static string AboutInfoDownloadFile = "AboutInfo.json";

        public static string VersionManifestDownloadLink = "https://raw.githubusercontent.com/yeppiidev/MinecraftDatapackStudio/main/Config/VersionInfo.json";
        public static string VersionManifestDownloadPath = "meta/minecraft/";
        public static string VersionManifestDownloadFile = "version_manifest.json";
    }
}
