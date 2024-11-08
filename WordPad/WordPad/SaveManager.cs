using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class SaveManager
    {
        RichTextBox richTextBox1;
        // Bien luu duong dan file hien tai(dùng cho open và save)
        static public string currentFilePath = string.Empty;
        public SaveManager(RichTextBox RTX)
        {
            richTextBox1 = RTX;
        }
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
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                // Goi phuong thuc SaveFile voi duong dan hien tai
                SaveFile(currentFilePath);
            }
            else
            {
                // Neu chua co duong dan (lan dau luu) thi goi chuc nang "Save As"
                SaveAs();
            }
        }
        //Save as
        public void SaveAs()
        {
            // Mo hop thoai de chon duong dan va ten file muon luu, chi luu duoi .txt hoac .rtf
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf", // Chi luu file dinh dang .txt hoac .rtf
                Title = "Save As" // Tieu de cua hop thoai
            };

            // Neu nguoi dung chon vi tri va ten file de luu
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cap nhat currentFilePath voi duong dan file duoc chon
                currentFilePath = saveFileDialog.FileName;
                // Luu file voi duong dan moi
                SaveFile(currentFilePath);
            }
        }
    }
}
