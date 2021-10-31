namespace MinecraftDatapackStudio
{
    partial class AboutForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.closeDialog = new System.Windows.Forms.Button();
            this.titleText = new System.Windows.Forms.Label();
            this.latestVersionLabel = new System.Windows.Forms.Label();
            this.contributorsLabel = new System.Windows.Forms.Label();
            this.contributorsList = new System.Windows.Forms.ListBox();
            this.latestVersionLabelInfo = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeDialog
            // 
            this.closeDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeDialog.BackColor = System.Drawing.SystemColors.ControlLight;
            this.closeDialog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.closeDialog.Location = new System.Drawing.Point(503, 348);
            this.closeDialog.Name = "closeDialog";
            this.closeDialog.Size = new System.Drawing.Size(75, 23);
            this.closeDialog.TabIndex = 0;
            this.closeDialog.Text = "Close";
            this.closeDialog.UseVisualStyleBackColor = false;
            this.closeDialog.Click += new System.EventHandler(this.CloseDialog_Click);
            // 
            // titleText
            // 
            this.titleText.AutoSize = true;
            this.titleText.Font = new System.Drawing.Font("Microsoft PhagsPa", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(12, 9);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(465, 46);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Minecraft Datapack Studio";
            // 
            // latestVersionLabel
            // 
            this.latestVersionLabel.AutoSize = true;
            this.latestVersionLabel.Location = new System.Drawing.Point(22, 68);
            this.latestVersionLabel.Name = "latestVersionLabel";
            this.latestVersionLabel.Size = new System.Drawing.Size(77, 13);
            this.latestVersionLabel.TabIndex = 2;
            this.latestVersionLabel.Text = "Latest Version:";
            // 
            // contributorsLabel
            // 
            this.contributorsLabel.AutoSize = true;
            this.contributorsLabel.Location = new System.Drawing.Point(33, 88);
            this.contributorsLabel.Name = "contributorsLabel";
            this.contributorsLabel.Size = new System.Drawing.Size(66, 13);
            this.contributorsLabel.TabIndex = 3;
            this.contributorsLabel.Text = "Contributors:";
            // 
            // contributorsList
            // 
            this.contributorsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contributorsList.FormattingEnabled = true;
            this.contributorsList.Items.AddRange(new object[] {
            "Loading..."});
            this.contributorsList.Location = new System.Drawing.Point(101, 88);
            this.contributorsList.Name = "contributorsList";
            this.contributorsList.Size = new System.Drawing.Size(477, 251);
            this.contributorsList.TabIndex = 4;
            // 
            // latestVersionLabelInfo
            // 
            this.latestVersionLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latestVersionLabelInfo.AutoSize = true;
            this.latestVersionLabelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latestVersionLabelInfo.Location = new System.Drawing.Point(98, 68);
            this.latestVersionLabelInfo.Name = "latestVersionLabelInfo";
            this.latestVersionLabelInfo.Size = new System.Drawing.Size(64, 13);
            this.latestVersionLabelInfo.TabIndex = 5;
            this.latestVersionLabelInfo.Text = "Loading...";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Brown;
            this.errorText.Location = new System.Drawing.Point(13, 357);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(146, 15);
            this.errorText.TabIndex = 6;
            this.errorText.Text = "Unable to load about info!";
            this.errorText.Visible = false;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(590, 383);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.latestVersionLabelInfo);
            this.Controls.Add(this.contributorsList);
            this.Controls.Add(this.contributorsLabel);
            this.Controls.Add(this.latestVersionLabel);
            this.Controls.Add(this.titleText);
            this.Controls.Add(this.closeDialog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Minecraft Datapack Studio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeDialog;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.Label latestVersionLabel;
        private System.Windows.Forms.Label contributorsLabel;
        private System.Windows.Forms.ListBox contributorsList;
        private System.Windows.Forms.Label latestVersionLabelInfo;
        private System.Windows.Forms.Label errorText;
    }
}
