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
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.Editor = new System.Windows.Forms.TabPage();
            this.darkGroupBox1 = new System.Windows.Forms.GroupBox();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.chooseFontBtn = new System.Windows.Forms.Button();
            this.fontSizeCounter = new System.Windows.Forms.NumericUpDown();
            this.fontPickerLbl = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.Label();
            this.ThemesGroup = new System.Windows.Forms.GroupBox();
            this.colorSchemePicker = new System.Windows.Forms.ComboBox();
            this.editorThemeLabel = new System.Windows.Forms.Label();
            this.projGen = new System.Windows.Forms.TabPage();
            this.gboxFilePaths = new System.Windows.Forms.GroupBox();
            this.chooseMcFolderBtn = new System.Windows.Forms.Button();
            this.mcFolderPathBox = new System.Windows.Forms.TextBox();
            this.mcinstallfolderlbl = new System.Windows.Forms.Label();
            this.fontPicker = new System.Windows.Forms.FontDialog();
            this.btnPanel.SuspendLayout();
            this.settingsTabs.SuspendLayout();
            this.Editor.SuspendLayout();
            this.darkGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeCounter)).BeginInit();
            this.ThemesGroup.SuspendLayout();
            this.projGen.SuspendLayout();
            this.gboxFilePaths.SuspendLayout();
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
            this.btnPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPanel.Controls.Add(this.okBtn);
            this.btnPanel.Controls.Add(this.cancelBtn);
            this.btnPanel.Controls.Add(this.applyBtn);
            this.btnPanel.Location = new System.Drawing.Point(-2, 419);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(720, 43);
            this.btnPanel.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.okBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okBtn.Location = new System.Drawing.Point(471, 11);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 5;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = false;
            this.okBtn.Click += new System.EventHandler(this.OnOkButtonClick);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(552, 11);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            // 
            // applyBtn
            // 
            this.applyBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.applyBtn.Enabled = false;
            this.applyBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.applyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyBtn.Location = new System.Drawing.Point(633, 11);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 3;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = false;
            this.applyBtn.Click += new System.EventHandler(this.OnApplyButtonClick);
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
            this.Editor.BackColor = System.Drawing.Color.White;
            this.Editor.Controls.Add(this.darkGroupBox1);
            this.Editor.Controls.Add(this.ThemesGroup);
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Editor.Size = new System.Drawing.Size(667, 297);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "Editor";
            // 
            // darkGroupBox1
            // 
            this.darkGroupBox1.BackColor = System.Drawing.Color.White;
            this.darkGroupBox1.Controls.Add(this.fontTextBox);
            this.darkGroupBox1.Controls.Add(this.chooseFontBtn);
            this.darkGroupBox1.Controls.Add(this.fontSizeCounter);
            this.darkGroupBox1.Controls.Add(this.fontPickerLbl);
            this.darkGroupBox1.Controls.Add(this.fontSize);
            this.darkGroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.darkGroupBox1.Location = new System.Drawing.Point(342, 6);
            this.darkGroupBox1.Name = "darkGroupBox1";
            this.darkGroupBox1.Size = new System.Drawing.Size(319, 283);
            this.darkGroupBox1.TabIndex = 3;
            this.darkGroupBox1.TabStop = false;
            this.darkGroupBox1.Text = "Fonts && Stuff";
            // 
            // fontTextBox
            // 
            this.fontTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fontTextBox.Location = new System.Drawing.Point(62, 45);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.Size = new System.Drawing.Size(170, 20);
            this.fontTextBox.TabIndex = 11;
            this.fontTextBox.TextChanged += new System.EventHandler(this.OnFontTextBoxTextChange);
            // 
            // chooseFontBtn
            // 
            this.chooseFontBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.chooseFontBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chooseFontBtn.Location = new System.Drawing.Point(236, 44);
            this.chooseFontBtn.Name = "chooseFontBtn";
            this.chooseFontBtn.Size = new System.Drawing.Size(70, 22);
            this.chooseFontBtn.TabIndex = 10;
            this.chooseFontBtn.Text = "Choose...";
            this.chooseFontBtn.UseVisualStyleBackColor = false;
            this.chooseFontBtn.Click += new System.EventHandler(this.OnChooseFontButtonClick);
            // 
            // fontSizeCounter
            // 
            this.fontSizeCounter.Location = new System.Drawing.Point(62, 19);
            this.fontSizeCounter.Name = "fontSizeCounter";
            this.fontSizeCounter.Size = new System.Drawing.Size(243, 20);
            this.fontSizeCounter.TabIndex = 9;
            this.fontSizeCounter.ValueChanged += new System.EventHandler(this.OnFontSizeVounterValueChanged);
            // 
            // fontPickerLbl
            // 
            this.fontPickerLbl.AutoSize = true;
            this.fontPickerLbl.Location = new System.Drawing.Point(30, 47);
            this.fontPickerLbl.Name = "fontPickerLbl";
            this.fontPickerLbl.Size = new System.Drawing.Size(31, 13);
            this.fontPickerLbl.TabIndex = 8;
            this.fontPickerLbl.Text = "Font:";
            // 
            // fontSize
            // 
            this.fontSize.AutoSize = true;
            this.fontSize.Location = new System.Drawing.Point(7, 22);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(54, 13);
            this.fontSize.TabIndex = 7;
            this.fontSize.Text = "Font Size:";
            // 
            // ThemesGroup
            // 
            this.ThemesGroup.BackColor = System.Drawing.Color.White;
            this.ThemesGroup.Controls.Add(this.colorSchemePicker);
            this.ThemesGroup.Controls.Add(this.editorThemeLabel);
            this.ThemesGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ThemesGroup.Location = new System.Drawing.Point(6, 6);
            this.ThemesGroup.Name = "ThemesGroup";
            this.ThemesGroup.Size = new System.Drawing.Size(330, 283);
            this.ThemesGroup.TabIndex = 5;
            this.ThemesGroup.TabStop = false;
            this.ThemesGroup.Text = "Themes";
            // 
            // colorSchemePicker
            // 
            this.colorSchemePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSchemePicker.FormattingEnabled = true;
            this.colorSchemePicker.Items.AddRange(new object[] {
            "Default Dark",
            "Default Light"});
            this.colorSchemePicker.Location = new System.Drawing.Point(87, 20);
            this.colorSchemePicker.Name = "colorSchemePicker";
            this.colorSchemePicker.Size = new System.Drawing.Size(229, 21);
            this.colorSchemePicker.TabIndex = 2;
            this.colorSchemePicker.SelectedValueChanged += new System.EventHandler(this.OnColorSchemePickerSelectedItemChanged);
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
            // 
            // projGen
            // 
            this.projGen.Controls.Add(this.gboxFilePaths);
            this.projGen.Location = new System.Drawing.Point(4, 22);
            this.projGen.Name = "projGen";
            this.projGen.Padding = new System.Windows.Forms.Padding(3);
            this.projGen.Size = new System.Drawing.Size(667, 297);
            this.projGen.TabIndex = 1;
            this.projGen.Text = "Project Generator";
            this.projGen.UseVisualStyleBackColor = true;
            // 
            // gboxFilePaths
            // 
            this.gboxFilePaths.Controls.Add(this.chooseMcFolderBtn);
            this.gboxFilePaths.Controls.Add(this.mcFolderPathBox);
            this.gboxFilePaths.Controls.Add(this.mcinstallfolderlbl);
            this.gboxFilePaths.Location = new System.Drawing.Point(7, 7);
            this.gboxFilePaths.Name = "gboxFilePaths";
            this.gboxFilePaths.Size = new System.Drawing.Size(654, 284);
            this.gboxFilePaths.TabIndex = 0;
            this.gboxFilePaths.TabStop = false;
            this.gboxFilePaths.Text = "File Paths";
            // 
            // chooseMcFolderBtn
            // 
            this.chooseMcFolderBtn.Location = new System.Drawing.Point(579, 16);
            this.chooseMcFolderBtn.Name = "chooseMcFolderBtn";
            this.chooseMcFolderBtn.Size = new System.Drawing.Size(68, 22);
            this.chooseMcFolderBtn.TabIndex = 2;
            this.chooseMcFolderBtn.Text = "Choose...\r\n";
            this.chooseMcFolderBtn.UseVisualStyleBackColor = true;
            this.chooseMcFolderBtn.Click += new System.EventHandler(this.ChooseMinecraftFolder);
            // 
            // mcFolderPathBox
            // 
            this.mcFolderPathBox.Location = new System.Drawing.Point(96, 17);
            this.mcFolderPathBox.Name = "mcFolderPathBox";
            this.mcFolderPathBox.Size = new System.Drawing.Size(478, 20);
            this.mcFolderPathBox.TabIndex = 1;
            this.mcFolderPathBox.TextChanged += new System.EventHandler(this.OnMinecraftFolderPathBoxTextChanged);
            // 
            // mcinstallfolderlbl
            // 
            this.mcinstallfolderlbl.AutoSize = true;
            this.mcinstallfolderlbl.Location = new System.Drawing.Point(10, 20);
            this.mcinstallfolderlbl.Name = "mcinstallfolderlbl";
            this.mcinstallfolderlbl.Size = new System.Drawing.Size(83, 13);
            this.mcinstallfolderlbl.TabIndex = 0;
            this.mcinstallfolderlbl.Text = "Minecraft folder:";
            // 
            // fontPicker
            // 
            this.fontPicker.FontMustExist = true;
            this.fontPicker.ShowApply = true;
            this.fontPicker.ShowEffects = false;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(718, 461);
            this.Controls.Add(this.settingsTabs);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.titleLbl);
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
            this.darkGroupBox1.ResumeLayout(false);
            this.darkGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeCounter)).EndInit();
            this.ThemesGroup.ResumeLayout(false);
            this.ThemesGroup.PerformLayout();
            this.projGen.ResumeLayout(false);
            this.gboxFilePaths.ResumeLayout(false);
            this.gboxFilePaths.PerformLayout();
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
        private System.Windows.Forms.GroupBox ThemesGroup;
        private System.Windows.Forms.ComboBox colorSchemePicker;
        private System.Windows.Forms.GroupBox darkGroupBox1;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.Button chooseFontBtn;
        private System.Windows.Forms.NumericUpDown fontSizeCounter;
        private System.Windows.Forms.Label fontPickerLbl;
        private System.Windows.Forms.Label fontSize;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.GroupBox gboxFilePaths;
        private System.Windows.Forms.Button chooseMcFolderBtn;
        private System.Windows.Forms.TextBox mcFolderPathBox;
        private System.Windows.Forms.Label mcinstallfolderlbl;
    }
}