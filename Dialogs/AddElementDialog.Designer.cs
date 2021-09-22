namespace MinecraftDatapackStudio.Dialogs {
    partial class AddElementDialog {
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
            this.header = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.elementTypeLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.elementType = new System.Windows.Forms.ComboBox();
            this.btnPanel = new System.Windows.Forms.Panel();
            this.errorText = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.btnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header.Location = new System.Drawing.Point(14, 15);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(215, 41);
            this.header.TabIndex = 0;
            this.header.Text = "Add Element";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name:";
            // 
            // elementTypeLbl
            // 
            this.elementTypeLbl.AutoSize = true;
            this.elementTypeLbl.Location = new System.Drawing.Point(27, 99);
            this.elementTypeLbl.Name = "elementTypeLbl";
            this.elementTypeLbl.Size = new System.Drawing.Size(67, 13);
            this.elementTypeLbl.TabIndex = 2;
            this.elementTypeLbl.Text = "Select Type:";
            // 
            // nameBox
            // 
            this.nameBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nameBox.Location = new System.Drawing.Point(95, 71);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(333, 20);
            this.nameBox.TabIndex = 3;
            // 
            // elementType
            // 
            this.elementType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.elementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.elementType.FormattingEnabled = true;
            this.elementType.Items.AddRange(new object[] {
            "Function",
            "Loot Table",
            "Recipe",
            "Advancement",
            "Dimension"});
            this.elementType.Location = new System.Drawing.Point(95, 96);
            this.elementType.Name = "elementType";
            this.elementType.Size = new System.Drawing.Size(333, 21);
            this.elementType.TabIndex = 4;
            // 
            // btnPanel
            // 
            this.btnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPanel.Controls.Add(this.errorText);
            this.btnPanel.Controls.Add(this.cancelBtn);
            this.btnPanel.Controls.Add(this.createBtn);
            this.btnPanel.Location = new System.Drawing.Point(1, 143);
            this.btnPanel.Name = "btnPanel";
            this.btnPanel.Size = new System.Drawing.Size(444, 41);
            this.btnPanel.TabIndex = 5;
            // 
            // errorText
            // 
            this.errorText.AutoSize = true;
            this.errorText.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText.ForeColor = System.Drawing.Color.Maroon;
            this.errorText.Location = new System.Drawing.Point(13, 14);
            this.errorText.Name = "errorText";
            this.errorText.Size = new System.Drawing.Size(36, 16);
            this.errorText.TabIndex = 2;
            this.errorText.Text = "Error";
            this.errorText.Visible = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.BackColor = System.Drawing.Color.White;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Location = new System.Drawing.Point(355, 10);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.OnCancelButtonClick);
            // 
            // createBtn
            // 
            this.createBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.createBtn.BackColor = System.Drawing.Color.White;
            this.createBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Location = new System.Drawing.Point(275, 10);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 23);
            this.createBtn.TabIndex = 0;
            this.createBtn.Text = "Add";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // AddElementDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(444, 183);
            this.Controls.Add(this.btnPanel);
            this.Controls.Add(this.elementType);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.elementTypeLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.header);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddElementDialog";
            this.ShowIcon = false;
            this.Text = "Add Element...";
            this.btnPanel.ResumeLayout(false);
            this.btnPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label elementTypeLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ComboBox elementType;
        private System.Windows.Forms.Panel btnPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Label errorText;
    }
}