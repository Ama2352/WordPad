namespace WordPad
{
    partial class InsertObjectForm
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
            this.radCreateNew = new System.Windows.Forms.RadioButton();
            this.radCreateFromFile = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOptionDescription = new System.Windows.Forms.Label();
            this.pictureBoxIllustration = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listOptions = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelCreateFromFile = new System.Windows.Forms.Panel();
            this.lblFileType = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkLink = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIllustration)).BeginInit();
            this.panelCreateFromFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // radCreateNew
            // 
            this.radCreateNew.AutoSize = true;
            this.radCreateNew.Location = new System.Drawing.Point(12, 55);
            this.radCreateNew.Name = "radCreateNew";
            this.radCreateNew.Size = new System.Drawing.Size(81, 17);
            this.radCreateNew.TabIndex = 0;
            this.radCreateNew.TabStop = true;
            this.radCreateNew.Text = "Create New";
            this.radCreateNew.UseVisualStyleBackColor = true;
            this.radCreateNew.CheckedChanged += new System.EventHandler(this.radCreateNew_CheckedChanged);
            // 
            // radCreateFromFile
            // 
            this.radCreateFromFile.AutoSize = true;
            this.radCreateFromFile.Location = new System.Drawing.Point(12, 87);
            this.radCreateFromFile.Name = "radCreateFromFile";
            this.radCreateFromFile.Size = new System.Drawing.Size(98, 17);
            this.radCreateFromFile.TabIndex = 1;
            this.radCreateFromFile.TabStop = true;
            this.radCreateFromFile.Text = "Create from File";
            this.radCreateFromFile.UseVisualStyleBackColor = true;
            this.radCreateFromFile.CheckedChanged += new System.EventHandler(this.radCreateFromFile_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOptionDescription);
            this.groupBox1.Controls.Add(this.pictureBoxIllustration);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(380, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Result";
            // 
            // lblOptionDescription
            // 
            this.lblOptionDescription.Location = new System.Drawing.Point(83, 30);
            this.lblOptionDescription.Name = "lblOptionDescription";
            this.lblOptionDescription.Size = new System.Drawing.Size(283, 50);
            this.lblOptionDescription.TabIndex = 1;
            this.lblOptionDescription.Text = "label2";
            // 
            // pictureBoxIllustration
            // 
            this.pictureBoxIllustration.Location = new System.Drawing.Point(15, 30);
            this.pictureBoxIllustration.Name = "pictureBoxIllustration";
            this.pictureBoxIllustration.Size = new System.Drawing.Size(47, 50);
            this.pictureBoxIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIllustration.TabIndex = 0;
            this.pictureBoxIllustration.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Object Type:";
            // 
            // listOptions
            // 
            this.listOptions.FormattingEnabled = true;
            this.listOptions.Location = new System.Drawing.Point(129, 55);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(249, 108);
            this.listOptions.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(398, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(99, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Display As Icon";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(398, 30);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(398, 59);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelCreateFromFile
            // 
            this.panelCreateFromFile.Controls.Add(this.chkLink);
            this.panelCreateFromFile.Controls.Add(this.btnBrowse);
            this.panelCreateFromFile.Controls.Add(this.txtPath);
            this.panelCreateFromFile.Controls.Add(this.lblFileType);
            this.panelCreateFromFile.Location = new System.Drawing.Point(118, 30);
            this.panelCreateFromFile.Name = "panelCreateFromFile";
            this.panelCreateFromFile.Size = new System.Drawing.Size(260, 145);
            this.panelCreateFromFile.TabIndex = 8;
            // 
            // lblFileType
            // 
            this.lblFileType.AutoSize = true;
            this.lblFileType.Location = new System.Drawing.Point(8, 34);
            this.lblFileType.Name = "lblFileType";
            this.lblFileType.Size = new System.Drawing.Size(26, 13);
            this.lblFileType.TabIndex = 0;
            this.lblFileType.Text = "File:";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(11, 54);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(227, 20);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(11, 89);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkLink
            // 
            this.chkLink.AutoSize = true;
            this.chkLink.Location = new System.Drawing.Point(104, 93);
            this.chkLink.Name = "chkLink";
            this.chkLink.Size = new System.Drawing.Size(46, 17);
            this.chkLink.TabIndex = 3;
            this.chkLink.Text = "Link";
            this.chkLink.UseVisualStyleBackColor = true;
            // 
            // InsertObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 318);
            this.Controls.Add(this.panelCreateFromFile);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listOptions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radCreateFromFile);
            this.Controls.Add(this.radCreateNew);
            this.Name = "InsertObjectForm";
            this.Text = "Insert Object";
            this.Load += new System.EventHandler(this.InsertObjectForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIllustration)).EndInit();
            this.panelCreateFromFile.ResumeLayout(false);
            this.panelCreateFromFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radCreateNew;
        private System.Windows.Forms.RadioButton radCreateFromFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxIllustration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listOptions;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblOptionDescription;
        private System.Windows.Forms.Panel panelCreateFromFile;
        private System.Windows.Forms.Label lblFileType;
        private System.Windows.Forms.CheckBox chkLink;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
    }
}