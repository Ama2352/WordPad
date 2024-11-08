using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class OpenManager
    {

        private RichTextBox richTextBox1;
        public OpenManager(RichTextBox RTX = null)
        {
            richTextBox1 = RTX;
        }

        //Hàm trả về path của file được mở để save có thể sử dụng tiếp
        public void Open()
        {
            // Mo hop thoai de chon file, chi hien thi cac file .txt va .rtf
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Chi hien thi cac file co dinh dang .txt hoac .rtf trong hop thoai
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf",
                Title = "Open File" // Tieu de cua hop thoai
            };

            // Kiem tra neu nguoi dung chon file va bam OK trong hop thoai
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lay duong dan cua file duoc chon
                string filePath = openFileDialog.FileName;

                // Neu file co duoi .rtf thi tai? noi dung voi RichTextBoxStreamType.RichText
                if (Path.GetExtension(filePath).ToLower() == ".rtf")
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else // Neu khong thi tai noi dung voi dinh dang PlainText
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }

                // Cap nhat bien currentFilePath voi duong dan file vua duoc mo
                SaveManager.currentFilePath = filePath;
            }
        }
    }
}
