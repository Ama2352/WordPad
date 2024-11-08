namespace WordPad
{
    partial class PasteSpecialForm
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
            this.lblTextSource = new System.Windows.Forms.Label();
            this.lblSourceDisplay = new System.Windows.Forms.Label();
            this.listOptions = new System.Windows.Forms.ListBox();
            this.radPaste = new System.Windows.Forms.RadioButton();
            this.radPasteLink = new System.Windows.Forms.RadioButton();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.picbIllustration = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.chkDisplayAsIcon = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblTextAs = new System.Windows.Forms.Label();
            this.grbResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbIllustration)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextSource
            // 
            this.lblTextSource.AutoSize = true;
            this.lblTextSource.Location = new System.Drawing.Point(24, 30);
            this.lblTextSource.Name = "lblTextSource";
            this.lblTextSource.Size = new System.Drawing.Size(47, 13);
            this.lblTextSource.TabIndex = 0;
            this.lblTextSource.Text = "Source: ";
            // 
            // lblSourceDisplay
            // 
            this.lblSourceDisplay.AutoSize = true;
            this.lblSourceDisplay.Location = new System.Drawing.Point(77, 30);
            this.lblSourceDisplay.Name = "lblSourceDisplay";
            this.lblSourceDisplay.Size = new System.Drawing.Size(103, 13);
            this.lblSourceDisplay.TabIndex = 1;
            this.lblSourceDisplay.Text = "Wordpad Document";
            // 
            // listOptions
            // 
            this.listOptions.FormattingEnabled = true;
            this.listOptions.Location = new System.Drawing.Point(121, 79);
            this.listOptions.Name = "listOptions";
            this.listOptions.Size = new System.Drawing.Size(202, 82);
            this.listOptions.TabIndex = 3;
            // 
            // radPaste
            // 
            this.radPaste.AutoSize = true;
            this.radPaste.Location = new System.Drawing.Point(19, 79);
            this.radPaste.Name = "radPaste";
            this.radPaste.Size = new System.Drawing.Size(52, 17);
            this.radPaste.TabIndex = 4;
            this.radPaste.TabStop = true;
            this.radPaste.Text = "Paste";
            this.radPaste.UseVisualStyleBackColor = true;
            // 
            // radPasteLink
            // 
            this.radPasteLink.AutoSize = true;
            this.radPasteLink.Location = new System.Drawing.Point(19, 123);
            this.radPasteLink.Name = "radPasteLink";
            this.radPasteLink.Size = new System.Drawing.Size(75, 17);
            this.radPasteLink.TabIndex = 5;
            this.radPasteLink.TabStop = true;
            this.radPasteLink.Text = "Paste Link";
            this.radPasteLink.UseVisualStyleBackColor = true;
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.picbIllustration);
            this.grbResult.Controls.Add(this.lblDescription);
            this.grbResult.Location = new System.Drawing.Point(19, 176);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(304, 100);
            this.grbResult.TabIndex = 6;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Result";
            // 
            // picbIllustration
            // 
            this.picbIllustration.Location = new System.Drawing.Point(18, 29);
            this.picbIllustration.Name = "picbIllustration";
            this.picbIllustration.Size = new System.Drawing.Size(43, 46);
            this.picbIllustration.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbIllustration.TabIndex = 1;
            this.picbIllustration.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(81, 29);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(202, 46);
            this.lblDescription.TabIndex = 0;
            // 
            // chkDisplayAsIcon
            // 
            this.chkDisplayAsIcon.AutoSize = true;
            this.chkDisplayAsIcon.Location = new System.Drawing.Point(338, 123);
            this.chkDisplayAsIcon.Name = "chkDisplayAsIcon";
            this.chkDisplayAsIcon.Size = new System.Drawing.Size(99, 17);
            this.chkDisplayAsIcon.TabIndex = 7;
            this.chkDisplayAsIcon.Text = "Display As Icon";
            this.chkDisplayAsIcon.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(338, 25);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(99, 23);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(338, 54);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblTextAs
            // 
            this.lblTextAs.AutoSize = true;
            this.lblTextAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextAs.Location = new System.Drawing.Point(118, 54);
            this.lblTextAs.Name = "lblTextAs";
            this.lblTextAs.Size = new System.Drawing.Size(22, 13);
            this.lblTextAs.TabIndex = 10;
            this.lblTextAs.Text = "As:";
            // 
            // PasteSpecialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 290);
            this.Controls.Add(this.lblTextAs);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkDisplayAsIcon);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.radPasteLink);
            this.Controls.Add(this.radPaste);
            this.Controls.Add(this.listOptions);
            this.Controls.Add(this.lblSourceDisplay);
            this.Controls.Add(this.lblTextSource);
            this.Name = "PasteSpecialForm";
            this.Text = "Paste Special";
            this.Load += new System.EventHandler(this.PasteSpecialForm_Load);
            this.grbResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbIllustration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextSource;
        private System.Windows.Forms.Label lblSourceDisplay;
        private System.Windows.Forms.ListBox listOptions;
        private System.Windows.Forms.RadioButton radPaste;
        private System.Windows.Forms.RadioButton radPasteLink;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.CheckBox chkDisplayAsIcon;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTextAs;
        private System.Windows.Forms.PictureBox picbIllustration;
        private System.Windows.Forms.Label lblDescription;
    }
}