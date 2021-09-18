namespace MinecraftDatapackStudio.Dialogs
{
    partial class NewProjectDialog
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
            this.labelHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.projDescLabel = new System.Windows.Forms.Label();
            this.chooseWorldLbl = new System.Windows.Forms.Label();
            this.createProjectButton = new DarkUI.Controls.DarkButton();
            this.cancelButton = new DarkUI.Controls.DarkButton();
            this.projNameBox = new DarkUI.Controls.DarkTextBox();
            this.projDescriptionBox = new DarkUI.Controls.DarkTextBox();
            this.minecraftVersionBox = new DarkUI.Controls.DarkComboBox();
            this.worldsList = new DarkUI.Controls.DarkListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft PhagsPa", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.Location = new System.Drawing.Point(13, 13);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(218, 48);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "New Project";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Project Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minecraft Version:";
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.errorText.Location = new System.Drawing.Point(12, 12);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(163, 14);
            this.errorText.TabIndex = 7;
            this.errorText.Text = "Unable to retrieve version list!";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.createProjectButton);
            this.panel1.Controls.Add(this.errorText);
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 40);
            this.panel1.TabIndex = 8;
            // 
            // projDescLabel
            // 
            this.projDescLabel.AutoSize = true;
            this.projDescLabel.Location = new System.Drawing.Point(22, 108);
            this.projDescLabel.Name = "projDescLabel";
            this.projDescLabel.Size = new System.Drawing.Size(99, 13);
            this.projDescLabel.TabIndex = 9;
            this.projDescLabel.Text = "Project Description:";
            // 
            // chooseWorldLbl
            // 
            this.chooseWorldLbl.AutoSize = true;
            this.chooseWorldLbl.Location = new System.Drawing.Point(44, 157);
            this.chooseWorldLbl.Name = "chooseWorldLbl";
            this.chooseWorldLbl.Size = new System.Drawing.Size(77, 13);
            this.chooseWorldLbl.TabIndex = 11;
            this.chooseWorldLbl.Text = "Choose World:";
            this.chooseWorldLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createProjectButton
            // 
            this.createProjectButton.Location = new System.Drawing.Point(376, 9);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Padding = new System.Windows.Forms.Padding(5);
            this.createProjectButton.Size = new System.Drawing.Size(75, 23);
            this.createProjectButton.TabIndex = 8;
            this.createProjectButton.Text = "Create";
            this.createProjectButton.Click += new System.EventHandler(this.CreateProject);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(457, 9);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Padding = new System.Windows.Forms.Padding(5);
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Click += new System.EventHandler(this.CancelClicked);
            // 
            // projNameBox
            // 
            this.projNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.projNameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.projNameBox.Location = new System.Drawing.Point(122, 79);
            this.projNameBox.Name = "projNameBox";
            this.projNameBox.Size = new System.Drawing.Size(399, 20);
            this.projNameBox.TabIndex = 12;
            // 
            // projDescriptionBox
            // 
            this.projDescriptionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.projDescriptionBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.projDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.projDescriptionBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.projDescriptionBox.Location = new System.Drawing.Point(122, 105);
            this.projDescriptionBox.Name = "projDescriptionBox";
            this.projDescriptionBox.Size = new System.Drawing.Size(399, 20);
            this.projDescriptionBox.TabIndex = 13;
            // 
            // minecraftVersionBox
            // 
            this.minecraftVersionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.minecraftVersionBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.minecraftVersionBox.FormattingEnabled = true;
            this.minecraftVersionBox.Items.AddRange(new object[] {
            "Loading items...."});
            this.minecraftVersionBox.Location = new System.Drawing.Point(122, 131);
            this.minecraftVersionBox.Name = "minecraftVersionBox";
            this.minecraftVersionBox.Size = new System.Drawing.Size(399, 21);
            this.minecraftVersionBox.TabIndex = 14;
            // 
            // worldsList
            // 
            this.worldsList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.worldsList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.worldsList.Location = new System.Drawing.Point(122, 158);
            this.worldsList.Name = "worldsList";
            this.worldsList.Size = new System.Drawing.Size(399, 95);
            this.worldsList.TabIndex = 15;
            this.worldsList.Text = "darkListView1";
            // 
            // NewProjectDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(544, 308);
            this.Controls.Add(this.worldsList);
            this.Controls.Add(this.minecraftVersionBox);
            this.Controls.Add(this.projDescriptionBox);
            this.Controls.Add(this.projNameBox);
            this.Controls.Add(this.chooseWorldLbl);
            this.Controls.Add(this.projDescLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHeader);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(560, 347);
            this.Name = "NewProjectDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New Project";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label projDescLabel;
        private System.Windows.Forms.Label chooseWorldLbl;
        private DarkUI.Controls.DarkButton createProjectButton;
        private DarkUI.Controls.DarkButton cancelButton;
        private DarkUI.Controls.DarkTextBox projNameBox;
        private DarkUI.Controls.DarkTextBox projDescriptionBox;
        private DarkUI.Controls.DarkComboBox minecraftVersionBox;
        private DarkUI.Controls.DarkListView worldsList;
    }
}