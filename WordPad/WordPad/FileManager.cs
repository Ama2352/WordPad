using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class FileManager
    {
        private NewManager _NewManager;
        private OpenManager _OpenManager;
        private SaveManager _SaveManager;
        private PrintManager _PrintManager;
        private SendEmailManager _SendEmailManager;
        TextBoxBehaviorManager _TextBoxBehaviorManager;
        public FileManager(RichTextBox RTX, Panel P, MainForm MF)
        {
            _NewManager = new NewManager(RTX, MF);
            _OpenManager = new OpenManager(RTX);
            _SaveManager = new SaveManager(RTX);
            _PrintManager = new PrintManager(ref P, MF);
            _SendEmailManager = new SendEmailManager(RTX);
            _TextBoxBehaviorManager = new TextBoxBehaviorManager(P, MF);
        }
        //About
        public void AboutWordpad()
        {
            MessageBox.Show("WordPad Clone\nPhiên bản 1.0\nĐược phát triển bởi Nhóm 7",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Exit
        public void Exit()
        {
            // Kiểm tra có cần lưu thay đổi trước khi thoát
            if (_NewManager.ConfirmSaveChanges())
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }

        //Các hàm sử dụng trong mainForm thuộc các đối tượng khác
        #region HamMF
        public void CenterTextBox()
        {
            _TextBoxBehaviorManager.CenterTextBox();
        }
        public void AdjustRichTextBoxToPageSetup()
        {
            _PrintManager.AdjustRichTextBoxToPageSetup();
        }
        public void ApllyMargin()
        {
            _PrintManager.ApllyMargin();
        }
        public void CreatNew()
        {
            _NewManager.CreatNew();
        }
        public void Open()
        {
            _OpenManager.Open();
        }
        public void Save(object sender, EventArgs e)
        {
            _SaveManager.Save(sender, e);
        }
        public void SaveAs()
        {
            _SaveManager.SaveAs();
        }
        public void PrintDoc()
        {
            _PrintManager.PrintDoc();
        }
        public void QuickPrint()
        {
            _PrintManager.QuickPrint();
        }
        public void ShowPageSetUp()
        {
            _PrintManager.ShowPageSetUp();
        }
        public void ShowPrintPreview()
        {
            _PrintManager.ShowPrintPreview();
        }
        public void SendEmail()
        {
            _SendEmailManager.SendEmail();
        }
        public void ChangePanelLocat(object sender, ScrollEventArgs e)
        {
            _TextBoxBehaviorManager.ChangePanelLocat(sender, e);
        }
        #endregion
    }
}
