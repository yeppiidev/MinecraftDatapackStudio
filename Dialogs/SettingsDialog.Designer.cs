namespace MinecraftDatapackStudio.Dialogs {
    partial class SettingsDialog {
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.Editor = new System.Windows.Forms.TabPage();
            this.ThemesGroup = new DarkUI.Controls.DarkGroupBox();
            this.colorSchemePicker = new DarkUI.Controls.DarkComboBox();
            this.editorThemeLabel = new System.Windows.Forms.Label();
            this.projGen = new System.Windows.Forms.TabPage();
            this.fontPicker = new System.Windows.Forms.FontDialog();
            this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
            this.fontTextBox = new DarkUI.Controls.DarkTextBox();
            this.chooseFontBtn = new DarkUI.Controls.DarkButton();
            this.fontSizeCounter = new DarkUI.Controls.DarkNumericUpDown();
            this.fontPickerLbl = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.Label();
            this.applyBtn = new DarkUI.Controls.DarkButton();
            this.cancelBtn = new DarkUI.Controls.DarkButton();
            this.okBtn = new DarkUI.Controls.DarkButton();
            this.btnPanel.SuspendLayout();
            this.settingsTabs.SuspendLayout();
            this.Editor.SuspendLayout();
            this.ThemesGroup.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeCounter)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.Location = new System.Drawing.Point(16, 17);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(155, 46);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Settings";
            // 
            // btnPanel
            // 
            this.btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.btnPanel.Controls.Add(this.okBtn);
            this.btnPanel.Controls.Add(this.cancelBtn);
            this.btnPanel.Controls.Add(this.applyBtn);
            this.btnPanel.Location = new System.Drawing.Point(-2, 419);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(720, 43);
            this.btnPanel.TabIndex = 1;
            // 
            // settingsTabs
            // 
            this.settingsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabs.Controls.Add(this.Editor);
            this.settingsTabs.Controls.Add(this.projGen);
            this.settingsTabs.HotTrack = true;
            this.settingsTabs.Location = new System.Drawing.Point(24, 80);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(675, 323);
            this.settingsTabs.TabIndex = 2;
            // 
            // Editor
            // 
            this.Editor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.Editor.Controls.Add(this.darkGroupBox1);
            this.Editor.Controls.Add(this.ThemesGroup);
            this.Editor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Editor.Size = new System.Drawing.Size(667, 297);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "Editor";
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
            // 
            // ThemesGroup
            // 
            this.ThemesGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ThemesGroup.BorderColor = System.Drawing.Color.White;
            this.ThemesGroup.Controls.Add(this.colorSchemePicker);
            this.ThemesGroup.Controls.Add(this.editorThemeLabel);
            this.ThemesGroup.Location = new System.Drawing.Point(6, 6);
            this.ThemesGroup.Name = "ThemesGroup";
            this.ThemesGroup.Size = new System.Drawing.Size(330, 283);
            this.ThemesGroup.TabIndex = 5;
            this.ThemesGroup.TabStop = false;
            this.ThemesGroup.Text = "Themes";
            // 
            // colorSchemePicker
            // 
            this.colorSchemePicker.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.colorSchemePicker.FormattingEnabled = true;
            this.colorSchemePicker.Items.AddRange(new object[] {
            "Default Dark",
            "Default Light"});
            this.colorSchemePicker.Location = new System.Drawing.Point(88, 19);
            this.colorSchemePicker.Name = "colorSchemePicker";
            this.colorSchemePicker.Size = new System.Drawing.Size(227, 21);
            this.colorSchemePicker.TabIndex = 2;
            // 
            // editorThemeLabel
            // 
            this.editorThemeLabel.AutoSize = true;
            this.editorThemeLabel.BackColor = System.Drawing.Color.Transparent;
            this.editorThemeLabel.Location = new System.Drawing.Point(9, 23);
            this.editorThemeLabel.Name = "editorThemeLabel";
            this.editorThemeLabel.Size = new System.Drawing.Size(76, 13);
            this.editorThemeLabel.TabIndex = 0;
            this.editorThemeLabel.Text = "Color Scheme:";
            this.editorThemeLabel.Click += new System.EventHandler(this.editorThemeLabel_Click);
            // 
            // projGen
            // 
            this.projGen.Location = new System.Drawing.Point(4, 22);
            this.projGen.Name = "projGen";
            this.projGen.Padding = new System.Windows.Forms.Padding(3);
            this.projGen.Size = new System.Drawing.Size(667, 306);
            this.projGen.TabIndex = 1;
            this.projGen.Text = "Project Generator";
            this.projGen.UseVisualStyleBackColor = true;
            // 
            // fontPicker
            // 
            this.fontPicker.FontMustExist = true;
            this.fontPicker.ShowApply = true;
            this.fontPicker.ShowEffects = false;
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.darkGroupBox1.BorderColor = System.Drawing.Color.White;
            this.darkGroupBox1.Controls.Add(this.fontTextBox);
            this.darkGroupBox1.Controls.Add(this.chooseFontBtn);
            this.darkGroupBox1.Controls.Add(this.fontSizeCounter);
            this.darkGroupBox1.Controls.Add(this.fontPickerLbl);
            this.darkGroupBox1.Controls.Add(this.fontSize);
            this.darkGroupBox1.Location = new System.Drawing.Point(342, 6);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(319, 283);
            this.darkGroupBox1.TabIndex = 3;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Fonts & Stuff";
            // 
            // fontTextBox
            // 
            this.fontTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.fontTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.fontTextBox.Location = new System.Drawing.Point(62, 45);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.Size = new System.Drawing.Size(170, 20);
            this.fontTextBox.TabIndex = 11;
            // 
            // chooseFontBtn
            // 
            this.chooseFontBtn.Location = new System.Drawing.Point(237, 45);
            this.chooseFontBtn.Name = "chooseFontBtn";
            this.chooseFontBtn.Padding = new System.Windows.Forms.Padding(5);
            this.chooseFontBtn.Size = new System.Drawing.Size(68, 20);
            this.chooseFontBtn.TabIndex = 10;
            this.chooseFontBtn.Text = "Choose...";
            // 
            // fontSizeCounter
            // 
            this.fontSizeCounter.Location = new System.Drawing.Point(62, 19);
            this.fontSizeCounter.Name = "fontSizeCounter";
            this.fontSizeCounter.Size = new System.Drawing.Size(243, 20);
            this.fontSizeCounter.TabIndex = 9;
            // 
            // fontPickerLbl
            // 
            this.fontPickerLbl.AutoSize = true;
            this.fontPickerLbl.Location = new System.Drawing.Point(29, 49);
            this.fontPickerLbl.Name = "fontPickerLbl";
            this.fontPickerLbl.Size = new System.Drawing.Size(31, 13);
            this.fontPickerLbl.TabIndex = 8;
            this.fontPickerLbl.Text = "Font:";
            // 
            // fontSize
            // 
            this.fontSize.AutoSize = true;
            this.fontSize.Location = new System.Drawing.Point(6, 23);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(54, 13);
            this.fontSize.TabIndex = 7;
            this.fontSize.Text = "Font Size:";
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(633, 10);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Padding = new System.Windows.Forms.Padding(5);
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(552, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Padding = new System.Windows.Forms.Padding(5);
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(471, 10);
            this.okBtn.Name = "okBtn";
            this.okBtn.Padding = new System.Windows.Forms.Padding(5);
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(718, 461);
            this.Controls.Add(this.settingsTabs);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.titleLbl);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.btnPanel.ResumeLayout(false);
            this.settingsTabs.ResumeLayout(false);
            this.Editor.ResumeLayout(false);
            this.ThemesGroup.ResumeLayout(false);
            this.ThemesGroup.PerformLayout();
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage Editor;
        private System.Windows.Forms.TabPage projGen;
        private System.Windows.Forms.Label editorThemeLabel;
        private System.Windows.Forms.FontDialog fontPicker;
        private DarkUI.Controls.DarkGroupBox ThemesGroup;
        private DarkUI.Controls.DarkComboBox colorSchemePicker;
        private DarkUI.Controls.DarkGroupBox darkGroupBox1;
        private DarkUI.Controls.DarkTextBox fontTextBox;
        private DarkUI.Controls.DarkButton chooseFontBtn;
        private DarkUI.Controls.DarkNumericUpDown fontSizeCounter;
        private System.Windows.Forms.Label fontPickerLbl;
        private System.Windows.Forms.Label fontSize;
        private DarkUI.Controls.DarkButton okBtn;
        private DarkUI.Controls.DarkButton cancelBtn;
        private DarkUI.Controls.DarkButton applyBtn;
    }
}