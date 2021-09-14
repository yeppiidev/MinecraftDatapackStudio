using System.Collections.Generic;

namespace MinecraftDatapackStudio.Data
{
    public class VersionManifest
    {
        public class latest
        {
            public string release { get; set; }
            public string snapshot { get; set; }
        }

        public List<Version> versions;
    }

    public class Version
    {
        public string id { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string time { get; set; }
        public string releaseTime { get; set; }
    }
}
