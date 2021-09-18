using System.Drawing;

namespace MinecraftDatapackStudio.Data {
    public class AppPreferences {
        public Editor Editor;
        public FilePaths FilePaths;
    }

    public class Editor {
        public Font Font;
        public int FontSize;
        public string Theme;
    }

    public class FilePaths {
        public string MinecraftInstallationDirectory;
    }
}
