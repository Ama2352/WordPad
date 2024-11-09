using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public string _imageDirectory { get; private set; } 
        public bool IsCopiedFromApplication { get; private set; } // Thuộc tính theo dõi nguồn

        public string linkText { get; private set; }
        public string typeOfLink {  get; private set; }

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
                case "Foxit PhantomPDF Document":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Foxit PhantomPDF Document object into your document. It will be displayed as an icon.", LoadImage(imagePath));

                case "Microsoft Word 97-2003 Document":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Excel 97-2003 Worksheet object into your document.", LoadImage(imagePath));

                case "Microsoft Word Document":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Word Document object into your document.", LoadImage(imagePath));

                case "Microsoft Word Macro-Enabled Document":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Word Macro-Enabled Document object into your document.", LoadImage(imagePath));

                case "nFoxit PhantomPDF Document":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new nFoxit PhantomPDF Document object into your document.", LoadImage(imagePath));

                case "OpenDocument Presentation":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new OpenDocument Presentation object into your document.", LoadImage(imagePath));

                case "OpenDocument Spreadsheet":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new OpenDocument Spreadsheet object into your document.", LoadImage(imagePath));

                case "OpenDocument Text":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new OpenDocument Text object into your document.", LoadImage(imagePath));

                case "Microsoft Excel 97-2003 Worksheet":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Excel 97-2003 Worksheet object into your document.", LoadImage(imagePath));

                case "Microsoft Excel Binary Worksheet":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Excel Binary Worksheet object into your document.", LoadImage(imagePath));

                case "Microsoft Excel Chart":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Excel Chart object into your document.", LoadImage(imagePath));

                case "Microsoft Excel Macro-Enabled Worksheet":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Excel Macro-Enabled Worksheet object into your document.", LoadImage(imagePath));

                case "Microsoft Excel Worksheet":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Excel Worksheet object into your document.", LoadImage(imagePath));

                case "Microsoft Worksheet":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Worksheet object into your document.", LoadImage(imagePath));

                case "Microsoft PowerPoint 97-2003 Presentation":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft PowerPoint 97-2003 Presentation object into your document.", LoadImage(imagePath));

                case "Microsoft PowerPoint 97-2003 Slide":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft PowerPoint 97-2003 Slide object into your document.", LoadImage(imagePath));

                case "Microsoft PowerPoint Macro-Enabled Presentation":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft PowerPoint Macro-Enabled Presentation object into your document.", LoadImage(imagePath));

                case "Microsoft PowerPoint Macro-Enabled Slide":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft PowerPoint Macro-Enabled Slide object into your document.", LoadImage(imagePath));

                case "Microsoft PowerPoint Presentation":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft PowerPoint Presentation object into your document.", LoadImage(imagePath));

                case "Microsoft PowerPoint Slide":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft PowerPoint Slide object into your document.", LoadImage(imagePath));

                case "Math Type 7.0 Equation":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Math Type 7.0 Equation object into your document.", LoadImage(imagePath));

                case "Microsoft Graph Chart":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Microsoft Graph Chart object into your document.", LoadImage(imagePath));

                case "Organization Chart Add-in for Microsoft":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Organization Chart Add-in for Microsoft object into your document.", LoadImage(imagePath));

                case "Package":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Package object into your document.", LoadImage(imagePath));

                case "Paintbrush Picture":
                    imagePath = Path.Combine(_imageDirectory, "paste.png");
                    return ("Inserts a new Paintbrush Picture object into your document.", LoadImage(imagePath));

                default:
                    return ("No description for this option.", null);
            }
        }

        // Phương thức tải ảnh từ đường dẫn, kiểm tra nếu ảnh tồn tại
        public Image LoadImage(string path)
        {
            return File.Exists(path) ? Image.FromFile(path) : null;
        }

        public void FormatWordLink(string linkText)
        {
            int wordIndex = _richTextBox.Text.IndexOf(linkText);

            if (wordIndex != -1) // Kiểm tra xem linkText có tồn tại không
            {
                MessageBox.Show("Running!");
                _richTextBox.Select(wordIndex, linkText.Length);
                _richTextBox.SelectionColor = Color.Blue;
                _richTextBox.SelectionFont = new Font(_richTextBox.Font, FontStyle.Underline);
                _richTextBox.DeselectAll();
            }
            else
            {
                MessageBox.Show("The specified link text was not found.", "Link Format Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void OpenDocumentIfLinkClicked(MouseEventArgs e)
        {
            if (_richTextBox != null && linkText != null)
            {
                int wordIndex = _richTextBox.Text.IndexOf(linkText);
                int charIndex = _richTextBox.GetCharIndexFromPosition(e.Location);

                if (charIndex >= wordIndex && charIndex < wordIndex + linkText.Length)
                {
                    try
                    {
                        string fileName = "";
                        switch (typeOfLink) // sử dụng linkText để xác định loại tài liệu
                        {
                            case "Wordpad Document":
                                fileName = "wordpad";
                                break;
                            case "Foxit PhantomPDF Document":
                                fileName = "FoxitPhantomPDF";
                                break;
                            case "Microsoft Word Document":
                                fileName = "winword";
                                break;
                            case "Microsoft Excel":
                                fileName = "excel";
                                break;
                            case "Microsoft PowerPoint Presentation":
                                fileName = "powerpnt";
                                break;
                            default:
                                MessageBox.Show("Unsupported document type.");
                                return;
                        }

                        Process.Start(new ProcessStartInfo
                        {
                            FileName = fileName,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Cannot open the application: " + ex.Message);
                    }
                }
            }
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
            else if (selectedOption == "Wordpad Document")
            {
                _richTextBox.SelectedRtf = Clipboard.GetData(DataFormats.Rtf).ToString();
                typeOfLink = "Microsoft Word Document";

                linkText = Clipboard.GetText();
                FormatWordLink(linkText);


                if (displayAsIcon)
                {

                }
            }
            /*else if (selectedOption == "Wordpad Document" || selectedOption == "Picture (Metafile)")
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
            }*/
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


