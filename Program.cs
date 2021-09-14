using CefSharp;
using CefSharp.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace MinecraftDatapackStudio
{
    static class Program
    {
        static void InitializeCEF()
        {
            var settings = new CefSettings();

            //We're going to manually call Cef.Shutdown below, this maybe required in some complex scenarios
            CefSharpSettings.ShutdownOnExit = false;

            settings.LogSeverity = LogSeverity.Error;
            settings.CachePath = Path.Combine(Environment.CurrentDirectory, "wikibrowser/cache");

            // Don't use a proxy server, always make direct connections. Overrides any other proxy server flags that are passed.
            // Slightly improves Cef initialize time as it won't attempt to resolve a proxy
            settings.CefCommandLineArgs.Add("no-proxy-server");

            //For Windows 7 and above, best to include relevant app.manifest entries as well
            Cef.EnableHighDPISupport();

            Cef.Initialize(settings);
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            InitializeCEF();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

            Cef.Shutdown();
        }
    }
}
