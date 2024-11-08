namespace TestingPageSetup
{
<<<<<<<< HEAD:WordPad/WordPad/MainForm.Designer.cs
    partial class MainForm
========
    partial class ExtraSettingsDialog
>>>>>>>> Quang:WordPad/WordPad/ExtraSettingsDialog.Designer.cs
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
            this.SuspendLayout();
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<<< HEAD:WordPad/WordPad/MainForm.Designer.cs
            this.Name = "MainForm";
            this.Text = "WordPad";
            this.ResumeLayout(false);

========
            this.Text = "ExtraSettingsDialog";
>>>>>>>> Quang:WordPad/WordPad/ExtraSettingsDialog.Designer.cs
        }

        #endregion
    }
}