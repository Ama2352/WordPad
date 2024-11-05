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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.btnInsertImage = new System.Windows.Forms.Button();
            this.btnInsertDateTime = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.strikethroughButton = new System.Windows.Forms.Button();
            this.subscriptButton = new System.Windows.Forms.Button();
            this.superscriptButton = new System.Windows.Forms.Button();
            this.highlightButton = new System.Windows.Forms.Button();
            this.growFontButton = new System.Windows.Forms.Button();
            this.shrinkFontButton = new System.Windows.Forms.Button();
            this.btnPasteSpecial = new System.Windows.Forms.Button();
            this.btnIncreaseIndent = new System.Windows.Forms.Button();
            this.btnDecreaseIndent = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.toolStripCombBulletStyles = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripDropDownButtonPicture = new System.Windows.Forms.ToolStripDropDownButton();
            this.insertPictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizePictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(197, 126);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(432, 238);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(197, 97);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(75, 23);
            this.btnCut.TabIndex = 1;
            this.btnCut.Text = "Cut";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(278, 97);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(359, 97);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 23);
            this.btnPaste.TabIndex = 3;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnBold
            // 
            this.btnBold.Location = new System.Drawing.Point(197, 372);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(75, 23);
            this.btnBold.TabIndex = 4;
            this.btnBold.Text = "Bold";
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.Location = new System.Drawing.Point(278, 372);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(75, 23);
            this.btnItalic.TabIndex = 5;
            this.btnItalic.Text = "Italic";
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.Location = new System.Drawing.Point(359, 372);
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
            this.fontFamilyComboBox.Location = new System.Drawing.Point(441, 373);
            this.fontFamilyComboBox.Name = "fontFamilyComboBox";
            this.fontFamilyComboBox.Size = new System.Drawing.Size(121, 21);
            this.fontFamilyComboBox.TabIndex = 7;
            this.fontFamilyComboBox.SelectedIndexChanged += new System.EventHandler(this.fontFamilyComboBox_SelectedIndexChanged);
            // 
            // fontSizeComboBox
            // 
            this.fontSizeComboBox.FormattingEnabled = true;
            this.fontSizeComboBox.Location = new System.Drawing.Point(568, 373);
            this.fontSizeComboBox.Name = "fontSizeComboBox";
            this.fontSizeComboBox.Size = new System.Drawing.Size(59, 21);
            this.fontSizeComboBox.TabIndex = 8;
            this.fontSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.fontSizeComboBox_SelectedIndexChanged);
            // 
            // btnColorPicker
            // 
            this.btnColorPicker.Location = new System.Drawing.Point(197, 402);
            this.btnColorPicker.Name = "btnColorPicker";
            this.btnColorPicker.Size = new System.Drawing.Size(75, 23);
            this.btnColorPicker.TabIndex = 9;
            this.btnColorPicker.Text = "Color";
            this.btnColorPicker.UseVisualStyleBackColor = true;
            this.btnColorPicker.Click += new System.EventHandler(this.btnColorPicker_Click);
            // 
            // btnAlignLeft
            // 
            this.btnAlignLeft.Location = new System.Drawing.Point(635, 126);
            this.btnAlignLeft.Name = "btnAlignLeft";
            this.btnAlignLeft.Size = new System.Drawing.Size(75, 23);
            this.btnAlignLeft.TabIndex = 10;
            this.btnAlignLeft.Text = "Align Left";
            this.btnAlignLeft.UseVisualStyleBackColor = true;
            this.btnAlignLeft.Click += new System.EventHandler(this.btnAlignLeft_Click);
            // 
            // btnAlignCenter
            // 
            this.btnAlignCenter.Location = new System.Drawing.Point(635, 156);
            this.btnAlignCenter.Name = "btnAlignCenter";
            this.btnAlignCenter.Size = new System.Drawing.Size(75, 23);
            this.btnAlignCenter.TabIndex = 11;
            this.btnAlignCenter.Text = "Align Center";
            this.btnAlignCenter.UseVisualStyleBackColor = true;
            this.btnAlignCenter.Click += new System.EventHandler(this.btnAlignCenter_Click);
            // 
            // btnAlignRight
            // 
            this.btnAlignRight.Location = new System.Drawing.Point(635, 186);
            this.btnAlignRight.Name = "btnAlignRight";
            this.btnAlignRight.Size = new System.Drawing.Size(75, 23);
            this.btnAlignRight.TabIndex = 12;
            this.btnAlignRight.Text = "Align Right";
            this.btnAlignRight.UseVisualStyleBackColor = true;
            this.btnAlignRight.Click += new System.EventHandler(this.btnAlignRight_Click);
            // 
            // btnInsertImage
            // 
            this.btnInsertImage.Location = new System.Drawing.Point(96, 126);
            this.btnInsertImage.Name = "btnInsertImage";
            this.btnInsertImage.Size = new System.Drawing.Size(95, 23);
            this.btnInsertImage.TabIndex = 15;
            this.btnInsertImage.Text = "Insert Image";
            this.btnInsertImage.UseVisualStyleBackColor = true;
            this.btnInsertImage.Click += new System.EventHandler(this.btnInsertImage_Click);
            // 
            // btnInsertDateTime
            // 
            this.btnInsertDateTime.Location = new System.Drawing.Point(96, 155);
            this.btnInsertDateTime.Name = "btnInsertDateTime";
            this.btnInsertDateTime.Size = new System.Drawing.Size(95, 23);
            this.btnInsertDateTime.TabIndex = 16;
            this.btnInsertDateTime.Text = "Insert Date/Time";
            this.btnInsertDateTime.UseVisualStyleBackColor = true;
            this.btnInsertDateTime.Click += new System.EventHandler(this.btnInsertDateTime_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(91, 230);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 17;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(91, 257);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(100, 20);
            this.txtReplace.TabIndex = 18;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(116, 341);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 19;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(116, 283);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 20;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(116, 312);
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
            this.lblSearch.Location = new System.Drawing.Point(38, 233);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(41, 13);
            this.lblSearch.TabIndex = 22;
            this.lblSearch.Text = "Search";
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(38, 260);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(47, 13);
            this.lblReplace.TabIndex = 23;
            this.lblReplace.Text = "Replace";
            // 
            // strikethroughButton
            // 
            this.strikethroughButton.Location = new System.Drawing.Point(22, 47);
            this.strikethroughButton.Name = "strikethroughButton";
            this.strikethroughButton.Size = new System.Drawing.Size(84, 23);
            this.strikethroughButton.TabIndex = 24;
            this.strikethroughButton.Text = "Strikethrough";
            this.strikethroughButton.UseVisualStyleBackColor = true;
            this.strikethroughButton.Click += new System.EventHandler(this.strikethroughButton_Click);
            // 
            // subscriptButton
            // 
            this.subscriptButton.Location = new System.Drawing.Point(112, 47);
            this.subscriptButton.Name = "subscriptButton";
            this.subscriptButton.Size = new System.Drawing.Size(75, 23);
            this.subscriptButton.TabIndex = 25;
            this.subscriptButton.Text = "Subscript";
            this.subscriptButton.UseVisualStyleBackColor = true;
            this.subscriptButton.Click += new System.EventHandler(this.subscriptButton_Click);
            // 
            // superscriptButton
            // 
            this.superscriptButton.Location = new System.Drawing.Point(197, 47);
            this.superscriptButton.Name = "superscriptButton";
            this.superscriptButton.Size = new System.Drawing.Size(75, 23);
            this.superscriptButton.TabIndex = 26;
            this.superscriptButton.Text = "Superscript";
            this.superscriptButton.UseVisualStyleBackColor = true;
            this.superscriptButton.Click += new System.EventHandler(this.superscriptButton_Click);
            // 
            // highlightButton
            // 
            this.highlightButton.Location = new System.Drawing.Point(278, 48);
            this.highlightButton.Name = "highlightButton";
            this.highlightButton.Size = new System.Drawing.Size(75, 23);
            this.highlightButton.TabIndex = 27;
            this.highlightButton.Text = "Hightlight";
            this.highlightButton.UseVisualStyleBackColor = true;
            this.highlightButton.Click += new System.EventHandler(this.highlightButton_Click);
            // 
            // growFontButton
            // 
            this.growFontButton.Location = new System.Drawing.Point(359, 48);
            this.growFontButton.Name = "growFontButton";
            this.growFontButton.Size = new System.Drawing.Size(75, 23);
            this.growFontButton.TabIndex = 28;
            this.growFontButton.Text = "GrowFont";
            this.growFontButton.UseVisualStyleBackColor = true;
            this.growFontButton.Click += new System.EventHandler(this.growFontButton_Click);
            // 
            // shrinkFontButton
            // 
            this.shrinkFontButton.Location = new System.Drawing.Point(440, 48);
            this.shrinkFontButton.Name = "shrinkFontButton";
            this.shrinkFontButton.Size = new System.Drawing.Size(75, 23);
            this.shrinkFontButton.TabIndex = 29;
            this.shrinkFontButton.Text = "ShrinkFont";
            this.shrinkFontButton.UseVisualStyleBackColor = true;
            this.shrinkFontButton.Click += new System.EventHandler(this.shrinkFontButton_Click);
            // 
            // btnPasteSpecial
            // 
            this.btnPasteSpecial.Location = new System.Drawing.Point(441, 97);
            this.btnPasteSpecial.Name = "btnPasteSpecial";
            this.btnPasteSpecial.Size = new System.Drawing.Size(86, 23);
            this.btnPasteSpecial.TabIndex = 30;
            this.btnPasteSpecial.Text = "Paste Special";
            this.btnPasteSpecial.UseVisualStyleBackColor = true;
            this.btnPasteSpecial.Click += new System.EventHandler(this.btnPasteSpecial_Click);
            // 
            // btnIncreaseIndent
            // 
            this.btnIncreaseIndent.Location = new System.Drawing.Point(634, 283);
            this.btnIncreaseIndent.Name = "btnIncreaseIndent";
            this.btnIncreaseIndent.Size = new System.Drawing.Size(92, 23);
            this.btnIncreaseIndent.TabIndex = 31;
            this.btnIncreaseIndent.Text = "Increase Indent";
            this.btnIncreaseIndent.UseVisualStyleBackColor = true;
            this.btnIncreaseIndent.Click += new System.EventHandler(this.btnIncreaseIndent_Click);
            // 
            // btnDecreaseIndent
            // 
            this.btnDecreaseIndent.Location = new System.Drawing.Point(635, 312);
            this.btnDecreaseIndent.Name = "btnDecreaseIndent";
            this.btnDecreaseIndent.Size = new System.Drawing.Size(75, 23);
            this.btnDecreaseIndent.TabIndex = 32;
            this.btnDecreaseIndent.Text = "Decrease Indent";
            this.btnDecreaseIndent.UseVisualStyleBackColor = true;
            this.btnDecreaseIndent.Click += new System.EventHandler(this.btnDecreaseIndent_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(225, 88);
            this.toolStripContainer1.Location = new System.Drawing.Point(568, 12);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(225, 88);
            this.toolStripContainer1.TabIndex = 33;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitButton1,
            this.toolStripDropDownButtonPicture});
            this.toolStrip1.Location = new System.Drawing.Point(9, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(143, 38);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCombBulletStyles});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(74, 35);
            this.toolStripSplitButton1.Text = "Start a list";
            this.toolStripSplitButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripCombBulletStyles
            // 
            this.toolStripCombBulletStyles.Name = "toolStripCombBulletStyles";
            this.toolStripCombBulletStyles.Size = new System.Drawing.Size(121, 23);
            this.toolStripCombBulletStyles.SelectedIndexChanged += new System.EventHandler(this.toolStripCombBulletStyles_SelectedIndexChanged);
            // 
            // toolStripDropDownButtonPicture
            // 
            this.toolStripDropDownButtonPicture.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertPictureToolStripMenuItem,
            this.changePictureToolStripMenuItem,
            this.resizePictureToolStripMenuItem});
            this.toolStripDropDownButtonPicture.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonPicture.Image")));
            this.toolStripDropDownButtonPicture.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonPicture.Name = "toolStripDropDownButtonPicture";
            this.toolStripDropDownButtonPicture.Size = new System.Drawing.Size(57, 35);
            this.toolStripDropDownButtonPicture.Text = "Picture";
            this.toolStripDropDownButtonPicture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDropDownButtonPicture.Click += new System.EventHandler(this.toolStripDropDownButtonPicture_Click);
            // 
            // insertPictureToolStripMenuItem
            // 
            this.insertPictureToolStripMenuItem.Name = "insertPictureToolStripMenuItem";
            this.insertPictureToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.insertPictureToolStripMenuItem.Text = "Insert Picture";
            this.insertPictureToolStripMenuItem.Click += new System.EventHandler(this.insertPictureToolStripMenuItem_Click);
            // 
            // changePictureToolStripMenuItem
            // 
            this.changePictureToolStripMenuItem.Name = "changePictureToolStripMenuItem";
            this.changePictureToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.changePictureToolStripMenuItem.Text = "Change Picture";
            this.changePictureToolStripMenuItem.Click += new System.EventHandler(this.changePictureToolStripMenuItem_Click);
            // 
            // resizePictureToolStripMenuItem
            // 
            this.resizePictureToolStripMenuItem.Name = "resizePictureToolStripMenuItem";
            this.resizePictureToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.resizePictureToolStripMenuItem.Text = "Resize Picture";
            this.resizePictureToolStripMenuItem.Click += new System.EventHandler(this.resizePictureToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 450);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.btnDecreaseIndent);
            this.Controls.Add(this.btnIncreaseIndent);
            this.Controls.Add(this.btnPasteSpecial);
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
            this.Text = "Wordpad";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button btnInsertImage;
        private System.Windows.Forms.Button btnInsertDateTime;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Button strikethroughButton;
        private System.Windows.Forms.Button subscriptButton;
        private System.Windows.Forms.Button superscriptButton;
        private System.Windows.Forms.Button highlightButton;
        private System.Windows.Forms.Button growFontButton;
        private System.Windows.Forms.Button shrinkFontButton;
        private System.Windows.Forms.Button btnPasteSpecial;
        private System.Windows.Forms.Button btnIncreaseIndent;
        private System.Windows.Forms.Button btnDecreaseIndent;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripComboBox toolStripCombBulletStyles;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonPicture;
        private System.Windows.Forms.ToolStripMenuItem insertPictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePictureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizePictureToolStripMenuItem;
    }
}

