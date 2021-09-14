namespace MinecraftDatapackStudio.Dialogs
{
    partial class WebBrowserDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.browser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.backBtn = new System.Windows.Forms.Button();
            this.forwardBtn = new System.Windows.Forms.Button();
            this.urlBox = new System.Windows.Forms.TextBox();
            this.reloadBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.windowStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // browser
            // 
            this.browser.ActivateBrowserOnCreation = false;
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.browser.Location = new System.Drawing.Point(0, 42);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(800, 406);
            this.browser.TabIndex = 0;
            this.browser.LoadError += new System.EventHandler<CefSharp.LoadErrorEventArgs>(this.OnLoadError);
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.backBtn.BackgroundImage = global::MinecraftDatapackStudio.Properties.Resources.icon_back;
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.Location = new System.Drawing.Point(6, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.backBtn.Size = new System.Drawing.Size(29, 29);
            this.backBtn.TabIndex = 1;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.forwardBtn.BackgroundImage = global::MinecraftDatapackStudio.Properties.Resources.icon_forward;
            this.forwardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forwardBtn.FlatAppearance.BorderSize = 0;
            this.forwardBtn.Location = new System.Drawing.Point(38, 5);
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.forwardBtn.Size = new System.Drawing.Size(29, 29);
            this.forwardBtn.TabIndex = 2;
            this.forwardBtn.UseVisualStyleBackColor = false;
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // urlBox
            // 
            this.urlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlBox.Location = new System.Drawing.Point(106, 10);
            this.urlBox.Name = "urlBox";
            this.urlBox.ReadOnly = true;
            this.urlBox.Size = new System.Drawing.Size(682, 20);
            this.urlBox.TabIndex = 3;
            // 
            // reloadBtn
            // 
            this.reloadBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.reloadBtn.BackgroundImage = global::MinecraftDatapackStudio.Properties.Resources.reload;
            this.reloadBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reloadBtn.FlatAppearance.BorderSize = 0;
            this.reloadBtn.Location = new System.Drawing.Point(70, 5);
            this.reloadBtn.Name = "reloadBtn";
            this.reloadBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.reloadBtn.Size = new System.Drawing.Size(29, 29);
            this.reloadBtn.TabIndex = 4;
            this.reloadBtn.UseVisualStyleBackColor = false;
            this.reloadBtn.Click += new System.EventHandler(this.reloadBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.windowStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // windowStatus
            // 
            this.windowStatus.Name = "windowStatus";
            this.windowStatus.Size = new System.Drawing.Size(59, 17);
            this.windowStatus.Text = "Loading...";
            // 
            // WebBrowserDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.reloadBtn);
            this.Controls.Add(this.urlBox);
            this.Controls.Add(this.forwardBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.browser);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "WebBrowserDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading...";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CefSharp.WinForms.ChromiumWebBrowser browser;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button forwardBtn;
        private System.Windows.Forms.TextBox urlBox;
        private System.Windows.Forms.Button reloadBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel windowStatus;
    }
}