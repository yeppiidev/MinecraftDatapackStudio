using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using CefSharp;
using MinecraftDatapackStudio.Browser;

namespace MinecraftDatapackStudio.Dialogs {
    public partial class WebBrowserDialog : Form {
        public WebBrowserDialog() {
            InitializeComponent();
            ResetIcon();

            browser.TitleChanged += OnTitleChange;
            browser.LoadError += OnLoadError;
            browser.FrameLoadEnd += OnFrameLoaded;

            forwardBtn.BackColor = forwardBtn.Enabled ? Color.Gainsboro : Color.Gray;
            backBtn.BackColor = backBtn.Enabled ? Color.Gainsboro : Color.Gray;
        }

        private void OnFrameLoaded(object sender, FrameLoadEndEventArgs e) {
            forwardBtn.Enabled = browser.CanGoForward;
            backBtn.Enabled = browser.CanGoBack;

            forwardBtn.BackColor = forwardBtn.Enabled ? Color.Gainsboro : Color.Gray;
            backBtn.BackColor = backBtn.Enabled ? Color.Gainsboro : Color.Gray;

            urlBox.Text = browser.GetMainFrame().Url;
        }

        private void OnLoadError(object sender, LoadErrorEventArgs e) {
            if (e.ErrorCode != CefErrorCode.Aborted) {
                windowStatus.Text = "Unable to load page: " + e.ErrorText;
                browser.LoadHtml(
                    "<html><head><style>html{font-family:-apple-system,BlinkMacSystemFont,\"Segoe UI\",\"Liberation Sans\",sans-serif;padding:10px;}</style><title>Unable to load page</title></head><body><h1>:(</h1><code>Unable to load page: " + e.ErrorText + "</code></body></html>"
                );
            }
        }

        private void OnTitleChange(object sender, TitleChangedEventArgs e) {
            this.InvokeOnUiThreadIfRequired(() => {
                Text = e.Title + " - Datapack Studio Wiki Browser";

                try {
                    WebClient wc = new WebClient();
                    MemoryStream memorystream = new MemoryStream(wc.DownloadData("http://" + new Uri(browser.Address.ToString()).Host + "/favicon.ico"));
                    Icon icon = new Icon(memorystream);
                    Icon = icon;
                } catch (Exception) {
                    ResetIcon();
                }
            });
        }

        public void ResetIcon() {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(MainForm));
            Icon = (Icon) resources.GetObject("$this.Icon");
        }

        public void LoadURL(string url) {
            browser.Load(url);
        }

        private void backBtn_Click(object sender, EventArgs e) {
            browser.Back();
        }

        private void forwardBtn_Click(object sender, EventArgs e) {
            browser.Forward();
        }

        private void reloadBtn_Click(object sender, EventArgs e) {
            browser.Reload();
        }
    }
}
