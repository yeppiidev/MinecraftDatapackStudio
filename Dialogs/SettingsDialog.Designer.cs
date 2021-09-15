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
            this.panel1 = new System.Windows.Forms.Panel();
            this.okBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.settingsTabs = new System.Windows.Forms.TabControl();
            this.Editor = new System.Windows.Forms.TabPage();
            this.projGen = new System.Windows.Forms.TabPage();
            this.themeGroup = new System.Windows.Forms.GroupBox();
            this.EditorSettings = new System.Windows.Forms.GroupBox();
            this.editorThemeLabel = new System.Windows.Forms.Label();
            this.colorSchemePicker = new System.Windows.Forms.ComboBox();
            this.fontSizeCounter = new System.Windows.Forms.NumericUpDown();
            this.fontSize = new System.Windows.Forms.Label();
            this.fontPicker = new System.Windows.Forms.FontDialog();
            this.fontPickerLbl = new System.Windows.Forms.Label();
            this.fontTextBox = new System.Windows.Forms.TextBox();
            this.chooseFontBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.settingsTabs.SuspendLayout();
            this.Editor.SuspendLayout();
            this.themeGroup.SuspendLayout();
            this.EditorSettings.SuspendLayout();
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.okBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.applyBtn);
            this.panel1.Location = new System.Drawing.Point(-2, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(720, 43);
            this.panel1.TabIndex = 1;
            // 
            // okBtn
            // 
            this.okBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okBtn.Location = new System.Drawing.Point(471, 10);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(552, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.applyBtn.Location = new System.Drawing.Point(633, 10);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(75, 23);
            this.applyBtn.TabIndex = 0;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // settingsTabs
            // 
            this.settingsTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsTabs.Controls.Add(this.Editor);
            this.settingsTabs.Controls.Add(this.projGen);
            this.settingsTabs.HotTrack = true;
            this.settingsTabs.Location = new System.Drawing.Point(24, 74);
            this.settingsTabs.Name = "settingsTabs";
            this.settingsTabs.SelectedIndex = 0;
            this.settingsTabs.Size = new System.Drawing.Size(675, 332);
            this.settingsTabs.TabIndex = 2;
            // 
            // Editor
            // 
            this.Editor.Controls.Add(this.EditorSettings);
            this.Editor.Controls.Add(this.themeGroup);
            this.Editor.Location = new System.Drawing.Point(4, 22);
            this.Editor.Name = "Editor";
            this.Editor.Padding = new System.Windows.Forms.Padding(3);
            this.Editor.Size = new System.Drawing.Size(667, 306);
            this.Editor.TabIndex = 0;
            this.Editor.Text = "Editor";
            this.Editor.UseVisualStyleBackColor = true;
            this.Editor.Click += new System.EventHandler(this.Editor_Click);
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
            // themeGroup
            // 
            this.themeGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.themeGroup.Controls.Add(this.colorSchemePicker);
            this.themeGroup.Controls.Add(this.editorThemeLabel);
            this.themeGroup.Location = new System.Drawing.Point(6, 5);
            this.themeGroup.Name = "themeGroup";
            this.themeGroup.Size = new System.Drawing.Size(328, 294);
            this.themeGroup.TabIndex = 0;
            this.themeGroup.TabStop = false;
            this.themeGroup.Text = "Themes";
            // 
            // EditorSettings
            // 
            this.EditorSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.EditorSettings.Controls.Add(this.chooseFontBtn);
            this.EditorSettings.Controls.Add(this.fontTextBox);
            this.EditorSettings.Controls.Add(this.fontPickerLbl);
            this.EditorSettings.Controls.Add(this.fontSize);
            this.EditorSettings.Controls.Add(this.fontSizeCounter);
            this.EditorSettings.Location = new System.Drawing.Point(342, 5);
            this.EditorSettings.Name = "EditorSettings";
            this.EditorSettings.Size = new System.Drawing.Size(317, 294);
            this.EditorSettings.TabIndex = 1;
            this.EditorSettings.TabStop = false;
            this.EditorSettings.Text = "Fonts && Others";
            this.EditorSettings.Enter += new System.EventHandler(this.EditorSettings_Enter);
            // 
            // editorThemeLabel
            // 
            this.editorThemeLabel.AutoSize = true;
            this.editorThemeLabel.Location = new System.Drawing.Point(10, 24);
            this.editorThemeLabel.Name = "editorThemeLabel";
            this.editorThemeLabel.Size = new System.Drawing.Size(76, 13);
            this.editorThemeLabel.TabIndex = 0;
            this.editorThemeLabel.Text = "Color Scheme:";
            // 
            // colorSchemePicker
            // 
            this.colorSchemePicker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorSchemePicker.FormattingEnabled = true;
            this.colorSchemePicker.Items.AddRange(new object[] {
            "Default Light",
            "Default Dark (Experimental)"});
            this.colorSchemePicker.Location = new System.Drawing.Point(89, 20);
            this.colorSchemePicker.Name = "colorSchemePicker";
            this.colorSchemePicker.Size = new System.Drawing.Size(225, 21);
            this.colorSchemePicker.TabIndex = 1;
            // 
            // fontSizeCounter
            // 
            this.fontSizeCounter.Location = new System.Drawing.Point(65, 23);
            this.fontSizeCounter.Name = "fontSizeCounter";
            this.fontSizeCounter.Size = new System.Drawing.Size(239, 20);
            this.fontSizeCounter.TabIndex = 0;
            // 
            // fontSize
            // 
            this.fontSize.AutoSize = true;
            this.fontSize.Location = new System.Drawing.Point(9, 26);
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(54, 13);
            this.fontSize.TabIndex = 1;
            this.fontSize.Text = "Font Size:";
            // 
            // fontPicker
            // 
            this.fontPicker.FontMustExist = true;
            this.fontPicker.ShowApply = true;
            this.fontPicker.ShowEffects = false;
            // 
            // fontPickerLbl
            // 
            this.fontPickerLbl.AutoSize = true;
            this.fontPickerLbl.Location = new System.Drawing.Point(32, 52);
            this.fontPickerLbl.Name = "fontPickerLbl";
            this.fontPickerLbl.Size = new System.Drawing.Size(31, 13);
            this.fontPickerLbl.TabIndex = 2;
            this.fontPickerLbl.Text = "Font:";
            this.fontPickerLbl.Click += new System.EventHandler(this.fontPickerLbl_Click);
            // 
            // fontTextBox
            // 
            this.fontTextBox.Location = new System.Drawing.Point(65, 48);
            this.fontTextBox.Name = "fontTextBox";
            this.fontTextBox.Size = new System.Drawing.Size(169, 20);
            this.fontTextBox.TabIndex = 3;
            // 
            // chooseFontBtn
            // 
            this.chooseFontBtn.Location = new System.Drawing.Point(239, 47);
            this.chooseFontBtn.Name = "chooseFontBtn";
            this.chooseFontBtn.Size = new System.Drawing.Size(65, 22);
            this.chooseFontBtn.TabIndex = 4;
            this.chooseFontBtn.Text = "Choose...";
            this.chooseFontBtn.UseVisualStyleBackColor = true;
            this.chooseFontBtn.Click += new System.EventHandler(this.chooseFontBtn_Click);
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(718, 461);
            this.Controls.Add(this.settingsTabs);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsDialog";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preferences";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.settingsTabs.ResumeLayout(false);
            this.Editor.ResumeLayout(false);
            this.themeGroup.ResumeLayout(false);
            this.themeGroup.PerformLayout();
            this.EditorSettings.ResumeLayout(false);
            this.EditorSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fontSizeCounter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.TabControl settingsTabs;
        private System.Windows.Forms.TabPage Editor;
        private System.Windows.Forms.TabPage projGen;
        private System.Windows.Forms.GroupBox themeGroup;
        private System.Windows.Forms.GroupBox EditorSettings;
        private System.Windows.Forms.Label editorThemeLabel;
        private System.Windows.Forms.TextBox fontTextBox;
        private System.Windows.Forms.Label fontPickerLbl;
        private System.Windows.Forms.Label fontSize;
        private System.Windows.Forms.NumericUpDown fontSizeCounter;
        private System.Windows.Forms.ComboBox colorSchemePicker;
        private System.Windows.Forms.FontDialog fontPicker;
        private System.Windows.Forms.Button chooseFontBtn;
    }
}