namespace MinecraftDatapackStudio.Dialogs
{
    partial class WelcomeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeDialog));
            this.welcomelabel = new System.Windows.Forms.Label();
            this.newProject = new System.Windows.Forms.Button();
            this.openProject = new System.Windows.Forms.Button();
            this.createBlankFile = new System.Windows.Forms.Button();
            this.newsBrowser = new CefSharp.WinForms.ChromiumWebBrowser();
            this.newsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomelabel.Location = new System.Drawing.Point(13, 13);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(318, 82);
            this.welcomelabel.TabIndex = 0;
            this.welcomelabel.Text = "Welcome!";
            // 
            // newProject
            // 
            this.newProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newProject.Location = new System.Drawing.Point(75, 143);
            this.newProject.Name = "newProject";
            this.newProject.Size = new System.Drawing.Size(182, 47);
            this.newProject.TabIndex = 1;
            this.newProject.Text = "Create New Project";
            this.newProject.UseVisualStyleBackColor = true;
            this.newProject.Click += new System.EventHandler(this.newProject_Click);
            // 
            // openProject
            // 
            this.openProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openProject.Location = new System.Drawing.Point(75, 196);
            this.openProject.Name = "openProject";
            this.openProject.Size = new System.Drawing.Size(182, 47);
            this.openProject.TabIndex = 2;
            this.openProject.Text = "Open Existing Project";
            this.openProject.UseVisualStyleBackColor = true;
            // 
            // createBlankFile
            // 
            this.createBlankFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createBlankFile.Location = new System.Drawing.Point(75, 248);
            this.createBlankFile.Name = "createBlankFile";
            this.createBlankFile.Size = new System.Drawing.Size(182, 47);
            this.createBlankFile.TabIndex = 3;
            this.createBlankFile.Text = "New Blank File";
            this.createBlankFile.UseVisualStyleBackColor = true;
            this.createBlankFile.Click += new System.EventHandler(this.Close);
            // 
            // newsBrowser
            // 
            this.newsBrowser.ActivateBrowserOnCreation = false;
            this.newsBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
// TODO: Code generation for '' failed because of Exception 'Invalid Primitive Type: System.IntPtr. Consider using CodeObjectCreateExpression.'.
            this.newsBrowser.Location = new System.Drawing.Point(350, 31);
            this.newsBrowser.Name = "newsBrowser";
            this.newsBrowser.Size = new System.Drawing.Size(430, 368);
            this.newsBrowser.TabIndex = 4;
            // 
            // newsLabel
            // 
            this.newsLabel.AutoSize = true;
            this.newsLabel.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsLabel.Location = new System.Drawing.Point(347, 9);
            this.newsLabel.Name = "newsLabel";
            this.newsLabel.Size = new System.Drawing.Size(163, 15);
            this.newsLabel.TabIndex = 5;
            this.newsLabel.Text = "Latest about Datapack Studio:";
            // 
            // WelcomeDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(793, 411);
            this.Controls.Add(this.newsLabel);
            this.Controls.Add(this.newsBrowser);
            this.Controls.Add(this.createBlankFile);
            this.Controls.Add(this.openProject);
            this.Controls.Add(this.newProject);
            this.Controls.Add(this.welcomelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WelcomeDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to Minecraft Datapack Studio!";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button newProject;
        private System.Windows.Forms.Button openProject;
        private System.Windows.Forms.Button createBlankFile;
        private CefSharp.WinForms.ChromiumWebBrowser newsBrowser;
        private System.Windows.Forms.Label newsLabel;
    }
}