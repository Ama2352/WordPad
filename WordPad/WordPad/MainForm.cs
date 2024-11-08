using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingPageSetup;
using System.Runtime.InteropServices;

namespace WordPad
{
    public partial class MainForm : Form
    {

        // Biến theo dõi thay đổi nội dung trong RichTextBox
        public static bool isTextChanged = false; 
        //Lấy giá trị scrollbar của rich text box
        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);
        private const int SB_VERT = 1; // Vertical scrollbar
        FileManager fileManager;

        public MainForm()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true; // Đánh dấu rằng nội dung đã thay đổi
            int verticalScrollPos = GetScrollPos(richTextBox1.Handle, SB_VERT);// Lấy vị trí của scrollbar dọc (Vertical)
            vScrollBar1.Value = verticalScrollPos;
            //MessageBox.Show($"{vScrollBar1.Maximum}\n{verticalScrollPos}\n{vScrollBar1.Minimum}\n{panel1.Height}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fileManager = new FileManager(richTextBox1, panel1, this);
            fileManager.CenterTextBox();
            fileManager.AdjustRichTextBoxToPageSetup();
            fileManager.ApllyMargin();
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            if (fileManager == null)
                return;
            fileManager.CenterTextBox();
        }
        #region ClickFunctions
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.CreatNew();
        }
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fileManager.Open();
        }
        public void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.Save(sender, e);
        }
        public void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.SaveAs();
        }
        private void printToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fileManager.PrintDoc();
        }
        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.ShowPageSetUp();
        }
        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.ShowPrintPreview();
        }
        private void sendInEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.SendEmail();
        }
        private void aboutWordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.AboutWordpad();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.Exit();
        }
        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            fileManager.ChangePanelLocat(sender, e);
        }

        private void quickPrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileManager.QuickPrint();
        }
        #endregion
    }
}
