namespace MinecraftDatapackStudio.Dialogs {
    partial class OpenProjectDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.selectWorldLabel = new System.Windows.Forms.Label();
            this.worldsList = new System.Windows.Forms.ListBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.choosePack = new System.Windows.Forms.Label();
            this.datapacksList = new System.Windows.Forms.ComboBox();
            this.header = new System.Windows.Forms.Label();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectWorldLabel
            // 
            this.selectWorldLabel.AutoSize = true;
            this.selectWorldLabel.Location = new System.Drawing.Point(24, 77);
            this.selectWorldLabel.Name = "selectWorldLabel";
            this.selectWorldLabel.Size = new System.Drawing.Size(77, 13);
            this.selectWorldLabel.TabIndex = 0;
            this.selectWorldLabel.Text = "Select a world:";
            // 
            // worldsList
            // 
            this.worldsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worldsList.FormattingEnabled = true;
            this.worldsList.Location = new System.Drawing.Point(106, 77);
            this.worldsList.Name = "worldsList";
            this.worldsList.Size = new System.Drawing.Size(483, 134);
            this.worldsList.TabIndex = 1;
            this.worldsList.SelectedIndexChanged += new System.EventHandler(this.OnSelectionChanged);
            // 
            // buttonPanel
            // 
            this.buttonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.openButton);
            this.buttonPanel.Location = new System.Drawing.Point(-1, 258);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(609, 45);
            this.buttonPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Location = new System.Drawing.Point(520, 12);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.openButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.openButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openButton.Location = new System.Drawing.Point(439, 12);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(75, 23);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenProject);
            // 
            // choosePack
            // 
            this.choosePack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.choosePack.AutoSize = true;
            this.choosePack.Location = new System.Drawing.Point(19, 222);
            this.choosePack.Name = "choosePack";
            this.choosePack.Size = new System.Drawing.Size(82, 13);
            this.choosePack.TabIndex = 3;
            this.choosePack.Text = "Choose a pack:";
            // 
            // datapacksList
            // 
            this.datapacksList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datapacksList.FormattingEnabled = true;
            this.datapacksList.Location = new System.Drawing.Point(106, 219);
            this.datapacksList.Name = "datapacksList";
            this.datapacksList.Size = new System.Drawing.Size(483, 21);
            this.datapacksList.TabIndex = 4;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft YaHei", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(10, 14);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(254, 48);
            this.header.TabIndex = 5;
            this.header.Text = "Open Project";
            // 
            // OpenProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 302);
            this.Controls.Add(this.header);
            this.Controls.Add(this.datapacksList);
            this.Controls.Add(this.choosePack);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.worldsList);
            this.Controls.Add(this.selectWorldLabel);
            this.Name = "OpenProjectDialog";
            this.ShowIcon = false;
            this.Text = "Open an existing project...";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label selectWorldLabel;
        private System.Windows.Forms.ListBox worldsList;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Label choosePack;
        private System.Windows.Forms.ComboBox datapacksList;
        private System.Windows.Forms.Label header;
    }
}