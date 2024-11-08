using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordPad
{
    internal class SaveManager2
    {
        RichTextBox richTextBox1;
        public void SaveFile(string filePath)
        {
            // Kiem tra dinh dang cua file dua tren phan mo rong (duoi file)
            if (Path.GetExtension(filePath).ToLower() == ".rtf")
            {
                // Luu noi dung RichTextBox vao file dinh dang RichText
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                // Luu noi dung RichTextBox vao file dinh dang PlainText
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
        }
        public void Save(object sender, EventArgs e)
        {
            // Kiem tra neu currentFilePath khong rong, nghia la file da duoc mo hoac luu truoc do
            if (!string.IsNullOrEmpty(MainForm.currentFilePath))
            {
                // Goi phuong thuc SaveFile voi duong dan hien tai
                SaveFile(MainForm.currentFilePath);
            }
            else
            {
                // Neu chua co duong dan (lan dau luu) thi goi chuc nang "Save As"
                //saveAsManager.SaveAs();
            }
        }

    }
}
