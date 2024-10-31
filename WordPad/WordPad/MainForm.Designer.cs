namespace WordPad
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.fontFamilyComboBox = new System.Windows.Forms.ComboBox();
            this.fontSizeComboBox = new System.Windows.Forms.ComboBox();
            this.btnColorPicker = new System.Windows.Forms.Button();
            this.btnAlignLeft = new System.Windows.Forms.Button();
            this.btnAlignCenter = new System.Windows.Forms.Button();
            this.btnAlignRight = new System.Windows.Forms.Button();
            this.btnIncreaseLineSpacing = new System.Windows.Forms.Button();
            this.btnDecreaseLineSpacing = new System.Windows.Forms.Button();
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.btnInsertDateTime = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.strikethroughButton = new System.Windows.Forms.Button();
            this.subscriptButton = new System.Windows.Forms.Button();
            this.superscriptButton = new System.Windows.Forms.Button();
            this.highlightButton = new System.Windows.Forms.Button();
            this.growFontButton = new System.Windows.Forms.Button();
            this.shrinkFontButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(187, 91);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(431, 239);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(187, 62);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 1;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(268, 62);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(349, 62);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(187, 337);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(75, 23);
            this.btnBold.TabIndex = 4;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(268, 337);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(75, 23);
            this.btnItalic.TabIndex = 5;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(349, 337);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(75, 23);
            this.btnUnderline.TabIndex = 6;
            this.btnUnderline.Text = "Underline";
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // fontFamilyComboBox
            // 
            this.fontFamilyComboBox.FormattingEnabled = true;
            this.fontFamilyComboBox.Location = new System.Drawing.Point(431, 338);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(121, 21);
            this.fontFamilyComboBox.TabIndex = 7;
            this.fontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyComboBox_SelectedIndexChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Location = new System.Drawing.Point(558, 338);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(59, 21);
            this.fontSizeComboBox.TabIndex = 8;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(187, 367);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(75, 23);
            this.btnColorPicker.TabIndex = 9;
            this.btnColorPicker.Text = "Color";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.Location = new System.Drawing.Point(625, 91);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAlignLeft.TabIndex = 10;
            this.btnAlignLeft.Text = "Align Left";
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.Location = new System.Drawing.Point(625, 121);
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(75, 23);
            this.btnAlignCenter.TabIndex = 11;
            this.btnAlignCenter.Text = "Align Center";
            this.btnAlignCenter.UseVisualStyleBackColor = true;
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.Location = new System.Drawing.Point(625, 151);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(75, 23);
            this.btnAlignRight.TabIndex = 12;
            this.btnAlignRight.Text = "Align Right";
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // btnIncreaseLineSpacing
            // 
            this.btnIncreaseLineSpacing.Location = new System.Drawing.Point(625, 181);
            this.btnIncreaseLineSpacing.Name = "btnIncreaseLineSpacing";
            this.btnIncreaseLineSpacing.Size = new System.Drawing.Size(140, 23);
            this.btnIncreaseLineSpacing.TabIndex = 13;
            this.btnIncreaseLineSpacing.Text = "Tăng khoảng cách dòng";
            this.btnIncreaseLineSpacing.UseVisualStyleBackColor = true;
            this.btnIncreaseLineSpacing.Click += new System.EventHandler(this.btnIncreaseLineSpacing_Click);
            // 
            // btnDecreaseLineSpacing
            // 
            this.btnDecreaseLineSpacing.Location = new System.Drawing.Point(625, 211);
            this.btnDecreaseLineSpacing.Name = "btnDecreaseLineSpacing";
            this.btnDecreaseLineSpacing.Size = new System.Drawing.Size(140, 23);
            this.btnDecreaseLineSpacing.TabIndex = 14;
            this.btnDecreaseLineSpacing.Text = "Giảm khoảng cách dòng";
            this.btnDecreaseLineSpacing.UseVisualStyleBackColor = true;
            this.btnDecreaseLineSpacing.Click += new System.EventHandler(this.btnDecreaseLineSpacing_Click);
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.Location = new System.Drawing.Point(86, 91);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(95, 23);
            this.btnInsertImage.TabIndex = 15;
            this.btnInsertImage.Text = "Insert Image";
            this.btnInsertImage.UseVisualStyleBackColor = true;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // btnInsertDateTime
            // 
            this.btnInsertDateTime.Location = new System.Drawing.Point(86, 120);
            this.btnInsertDateTime.Name = "btnInsertDateTime";
            this.btnInsertDateTime.Size = new System.Drawing.Size(95, 23);
            this.btnInsertDateTime.TabIndex = 16;
            this.btnInsertDateTime.Text = "Insert Date/Time";
            this.btnInsertDateTime.UseVisualStyleBackColor = true;
            this.btnInsertDateTime.Click += new System.EventHandler(this.btnInsertDateTime_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(81, 195);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(81, 222);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(100, 20);
            this.txtReplace.TabIndex = 18;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(106, 306);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 19;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(106, 248);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(106, 277);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 21;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(28, 198);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(28, 225);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(47, 13);
            this.lblReplace.TabIndex = 23;
            this.lblReplace.Text = "Replace";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // strikethroughButton
            // 
            this.strikethroughButton.Location = new System.Drawing.Point(12, 12);
            this.strikethroughButton.Name = "strikethroughButton";
            this.strikethroughButton.Size = new System.Drawing.Size(84, 23);
            this.strikethroughButton.TabIndex = 24;
            this.strikethroughButton.Text = "Strikethrough";
            this.strikethroughButton.UseVisualStyleBackColor = true;
            this.strikethroughButton.Click += new System.EventHandler(this.strikethroughButton_Click);
            // 
            // subscriptButton
            // 
            this.subscriptButton.Location = new System.Drawing.Point(102, 12);
            this.subscriptButton.Name = "subscriptButton";
            this.subscriptButton.Size = new System.Drawing.Size(75, 23);
            this.subscriptButton.TabIndex = 25;
            this.subscriptButton.Text = "Subscript";
            this.subscriptButton.UseVisualStyleBackColor = true;
            this.subscriptButton.Click += new System.EventHandler(this.subscriptButton_Click);
            // 
            // superscriptButton
            // 
            this.superscriptButton.Location = new System.Drawing.Point(187, 12);
            this.superscriptButton.Name = "superscriptButton";
            this.superscriptButton.Size = new System.Drawing.Size(75, 23);
            this.superscriptButton.TabIndex = 26;
            this.superscriptButton.Text = "Superscript";
            this.superscriptButton.UseVisualStyleBackColor = true;
            this.superscriptButton.Click += new System.EventHandler(this.superscriptButton_Click);
            // 
            // highlightButton
            // 
            this.highlightButton.Location = new System.Drawing.Point(268, 13);
            this.highlightButton.Name = "highlightButton";
            this.highlightButton.Size = new System.Drawing.Size(75, 23);
            this.highlightButton.TabIndex = 27;
            this.highlightButton.Text = "Hightlight";
            this.highlightButton.UseVisualStyleBackColor = true;
            this.highlightButton.Click += new System.EventHandler(this.highlightButton_Click);
            // 
            // growFontButton
            // 
            this.growFontButton.Location = new System.Drawing.Point(349, 13);
            this.growFontButton.Name = "growFontButton";
            this.growFontButton.Size = new System.Drawing.Size(75, 23);
            this.growFontButton.TabIndex = 28;
            this.growFontButton.Text = "GrowFont";
            this.growFontButton.UseVisualStyleBackColor = true;
            this.growFontButton.Click += new System.EventHandler(this.growFontButton_Click);
            // 
            // shrinkFontButton
            // 
            this.shrinkFontButton.Location = new System.Drawing.Point(430, 13);
            this.shrinkFontButton.Name = "shrinkFontButton";
            this.shrinkFontButton.Size = new System.Drawing.Size(75, 23);
            this.shrinkFontButton.TabIndex = 29;
            this.shrinkFontButton.Text = "ShrinkFont";
            this.shrinkFontButton.UseVisualStyleBackColor = true;
            this.shrinkFontButton.Click += new System.EventHandler(this.shrinkFontButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.shrinkFontButton);
            this.Controls.Add(this.growFontButton);
            this.Controls.Add(this.highlightButton);
            this.Controls.Add(this.superscriptButton);
            this.Controls.Add(this.subscriptButton);
            this.Controls.Add(this.strikethroughButton);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.txtReplace);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnInsertDateTime);
            this.Controls.Add(this.btnInsertImage);
            this.Controls.Add(this.btnDecreaseLineSpacing);
            this.Controls.Add(this.btnIncreaseLineSpacing);
            this.Controls.Add(this.btnAlignRight);
            this.Controls.Add(this.btnAlignCenter);
            this.Controls.Add(this.btnAlignLeft);
            this.Controls.Add(this.btnColorPicker);
            this.Controls.Add(this.fontSizeComboBox);
            this.Controls.Add(this.fontFamilyComboBox);
            this.Controls.Add(this.btnUnderline);
            this.Controls.Add(this.btnItalic);
            this.Controls.Add(this.btnBold);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.richTextBox1);
            this.Name = "MainForm";
            this.Text = "WordPad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.ComboBox fontFamilyComboBox;
        private System.Windows.Forms.ComboBox fontSizeComboBox;
        private System.Windows.Forms.Button btnColorPicker;
        private System.Windows.Forms.Button btnAlignLeft;
        private System.Windows.Forms.Button btnAlignCenter;
        private System.Windows.Forms.Button btnAlignRight;
        private System.Windows.Forms.Button btnIncreaseLineSpacing;
        private System.Windows.Forms.Button btnDecreaseLineSpacing;
        private System.Windows.Forms.Button btnInsertImage;
        private System.Windows.Forms.Button btnInsertDateTime;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button strikethroughButton;
        private System.Windows.Forms.Button subscriptButton;
        private System.Windows.Forms.Button superscriptButton;
        private System.Windows.Forms.Button highlightButton;
        private System.Windows.Forms.Button growFontButton;
        private System.Windows.Forms.Button shrinkFontButton;
    }
}

