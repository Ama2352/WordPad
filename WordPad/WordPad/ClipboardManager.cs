using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public class ClipboardManager
    {
        private RichTextBox _richTextBox;
        private string _imageDirectory;
        public bool IsCopiedFromApplication { get; private set; } // Thuộc tính theo dõi nguồn

        // Khởi tạo với tham chiếu tới RichTextBox
        public ClipboardManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
            _imageDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, 
                "C:/Users/Admin/Documents/GitHub/WordPad/WordPad/WordPad/Images");
            IsCopiedFromApplication = false; // Khởi tạo giá trị mặc định

        }

        // Phương thức Cắt
        public void Cut()
        {
            if (_richTextBox.SelectedText.Length > 0)
            {
                _richTextBox.Cut();
                IsCopiedFromApplication = true; // Đánh dấu là đã sao chép từ ứng dụng
            }
            else
            {
                MessageBox.Show("No text selected to cut.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Phương thức Sao chép
        public void Copy()
        {
            if (_richTextBox.SelectedText.Length > 0)
            {
                _richTextBox.Copy();
                IsCopiedFromApplication = true; // Đánh dấu là đã sao chép từ ứng dụng
            }
            else
            {
                MessageBox.Show("No text selected to copy.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Phương thức Dán
        public void Paste()
        {
            if (Clipboard.ContainsData(DataFormats.Rtf) ||
                Clipboard.ContainsData(DataFormats.Text) ||
                Clipboard.ContainsData(DataFormats.Text) ||
                Clipboard.ContainsImage())
            {
                _richTextBox.Paste();

                // Đặt lại IsCopiedFromApplication sau khi dán
                IsCopiedFromApplication = false;
            }
            else
            {
                MessageBox.Show("Clipboard is empty.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Phương thức lấy các tùy chọn dán từ clipboard
        public List<string> GetPasteOptions()
        {
            List<string> options = new List<string>();

            // Kiểm tra clipboard và thêm các tùy chọn tương ứng vào danh sách
            if (Clipboard.ContainsData(DataFormats.Rtf))
            {
                options.Add("Rich Text (RTF)");
            }

            if (Clipboard.ContainsData(DataFormats.Text))
            {
                options.Add("Unformatted Text");
            }

            if (Clipboard.ContainsImage())
            {              
                options.Add("Device Independent Bitmap");
                options.Add("Bitmap");
            }

            // Nếu clipboard có nội dung văn bản từ WordPad
            if (Clipboard.ContainsText())
            {
                options.Add("Wordpad Document");
                options.Add("Picture (Metafile)");
            }

            return options;
        }

        // Lấy mô tả và hình ảnh minh họa cho tùy chọn được chọn
        public (string Description, Image Illustration) GetOptionDetails(string option)
        {
            string imagePath = string.Empty;
            switch (option)
            {
                case "Rich Text (RTF)":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts the contents of the clipboard into your document as text with font and paragraph formatting.",
                            LoadImage(imagePath));

                case "Unformatted Text":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts the contents of the clipboard into your document as text without any formatting.",
                            LoadImage(imagePath));

                case "Picture (Metafile)":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts the contents of the clipboard into your document as a picture.",
                            LoadImage(imagePath));

                case "Device Independent Bitmap":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts the contents of the clipboard into your document as a device independent bitmap.",
                            LoadImage(imagePath));

                case "Bitmap":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts the contents of the clipboard into your document as a bitmap.",
                            LoadImage(imagePath));

                case "Wordpad Document":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts the contents of the clipboard into your document so that you may activate it using WordPad.",
                            LoadImage(imagePath));

                default:
                    return ("No descripion for this part.", null);
            }
        }

        // Phương thức tải ảnh từ đường dẫn, kiểm tra nếu ảnh tồn tại
        private Image LoadImage(string path)
        {
            return File.Exists(path) ? Image.FromFile(path) : null;
        }


        public void PasteSpecial(string selectedOption, bool displayAsIcon)
        {
            if (selectedOption == "Rich Text (RTF)" && Clipboard.ContainsData(DataFormats.Rtf))
            {
                _richTextBox.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
            }
            else if (selectedOption == "Unformatted Text" && Clipboard.ContainsData(DataFormats.Text))
            {
                _richTextBox.SelectedText = Clipboard.GetText();
            }
            else if ((selectedOption == "Device Independent Bitmap" || selectedOption == "Bitmap") && Clipboard.ContainsImage())
            {
                _richTextBox.Paste();
            }
            else if (selectedOption == "Wordpad Document" || selectedOption == "Picture (Metafile)")
            {
                if (displayAsIcon)
                {
                    // Dán icon thay vì nội dung
                    var icon = SystemIcons.Application; // Sử dụng icon mặc định
                    Clipboard.SetImage(icon.ToBitmap());
                    _richTextBox.Paste();
                }
                else if (Clipboard.ContainsText())
                {
                    _richTextBox.AppendText(Clipboard.GetText());
                }
                else
                {
                    MessageBox.Show("Clipboard does not contain the appropriate data.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No valid paste option selected.", "Paste Special", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool CanPasteLink()
        {
            // Giả lập rằng Paste Link sẽ được cho phép với định dạng HTML hoặc định dạng OEM text
            return Clipboard.ContainsData(DataFormats.Html) || Clipboard.ContainsData(DataFormats.OemText);
        }

    }
}


