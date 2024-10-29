using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class InsertManager
    {
        private RichTextBox _richTextBox;

        // Khởi tạo với tham chiếu tới RichTextBox
        public InsertManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        // Phương thức chèn hình ảnh
        public void InsertImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    Clipboard.SetImage(img); // Chuyển hình ảnh vào Clipboard

                    // Kiểm tra và chèn hình ảnh
                    if (_richTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                    {
                        _richTextBox.Paste();
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert image.", "Insert Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Phương thức chèn ngày/giờ
        public void InsertDateTime()
        {
            string dateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            _richTextBox.AppendText(dateTime);
        }
    }
}
