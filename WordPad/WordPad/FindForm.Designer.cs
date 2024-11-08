﻿namespace WordPad
{
    partial class FindForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.chkMatchWholeWordOnly = new System.Windows.Forms.CheckBox();
            this.chkMatchCase = new System.Windows.Forms.CheckBox();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find what:";
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(74, 24);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(239, 20);
            this.txtSearchText.TabIndex = 1;
            // 
            // chkMatchWholeWordOnly
            // 
            this.chkMatchWholeWordOnly.AutoSize = true;
            this.chkMatchWholeWordOnly.Location = new System.Drawing.Point(15, 69);
            this.chkMatchWholeWordOnly.Name = "chkMatchWholeWordOnly";
            this.chkMatchWholeWordOnly.Size = new System.Drawing.Size(135, 17);
            this.chkMatchWholeWordOnly.TabIndex = 2;
            this.chkMatchWholeWordOnly.Text = "Match whole word only";
            this.chkMatchWholeWordOnly.UseVisualStyleBackColor = true;
            // 
            // chkMatchCase
            // 
            this.chkMatchCase.AutoSize = true;
            this.chkMatchCase.Location = new System.Drawing.Point(15, 92);
            this.chkMatchCase.Name = "chkMatchCase";
            this.chkMatchCase.Size = new System.Drawing.Size(82, 17);
            this.chkMatchCase.TabIndex = 3;
            this.chkMatchCase.Text = "Match case";
            this.chkMatchCase.UseVisualStyleBackColor = true;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Location = new System.Drawing.Point(319, 22);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(75, 23);
            this.btnFindNext.TabIndex = 4;
            this.btnFindNext.Text = "Find next";
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(319, 51);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 125);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.chkMatchCase);
            this.Controls.Add(this.chkMatchWholeWordOnly);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.label1);
            this.Name = "FindForm";
            this.Text = "Find";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FindForm_FormClosing);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FindForm_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.CheckBox chkMatchWholeWordOnly;
        private System.Windows.Forms.CheckBox chkMatchCase;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.Button btnCancel;
    }
}