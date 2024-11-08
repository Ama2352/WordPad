namespace WordPad
{
    partial class ResizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResizeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownHorizontal = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownVertical = new System.Windows.Forms.NumericUpDown();
            this.chkLockAspectRatio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorizontal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVertical)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resize relative to original picture size";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(323, 15);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(323, 44);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(36, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(36, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horizontal: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vertical: ";
            // 
            // numericUpDownHorizontal
            // 
            this.numericUpDownHorizontal.Location = new System.Drawing.Point(174, 58);
            this.numericUpDownHorizontal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownHorizontal.Name = "numericUpDownHorizontal";
            this.numericUpDownHorizontal.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownHorizontal.TabIndex = 7;
            // 
            // numericUpDownVertical
            // 
            this.numericUpDownVertical.Location = new System.Drawing.Point(174, 126);
            this.numericUpDownVertical.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownVertical.Name = "numericUpDownVertical";
            this.numericUpDownVertical.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownVertical.TabIndex = 8;
            // 
            // chkLockAspectRatio
            // 
            this.chkLockAspectRatio.AutoSize = true;
            this.chkLockAspectRatio.Location = new System.Drawing.Point(36, 206);
            this.chkLockAspectRatio.Name = "chkLockAspectRatio";
            this.chkLockAspectRatio.Size = new System.Drawing.Size(114, 17);
            this.chkLockAspectRatio.TabIndex = 9;
            this.chkLockAspectRatio.Text = "Lock Aspect Ratio";
            this.chkLockAspectRatio.UseVisualStyleBackColor = true;
            this.chkLockAspectRatio.CheckedChanged += new System.EventHandler(this.checkBoxLockAspectRatio_CheckedChanged);
            // 
            // ResizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 233);
            this.Controls.Add(this.chkLockAspectRatio);
            this.Controls.Add(this.numericUpDownVertical);
            this.Controls.Add(this.numericUpDownHorizontal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Name = "ResizeForm";
            this.Text = "ResizeForm";
            this.Load += new System.EventHandler(this.ResizeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHorizontal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVertical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownHorizontal;
        private System.Windows.Forms.NumericUpDown numericUpDownVertical;
        private System.Windows.Forms.CheckBox chkLockAspectRatio;
    }
}