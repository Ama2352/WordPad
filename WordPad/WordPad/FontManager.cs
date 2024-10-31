using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class FontManager
    {
        private RichTextBox _richTextBox;
        private int[] fontSize = new int[] { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
        public event Action<float> FontSizeChanged;

        // Khởi tạo với tham chiếu tới RichTextBox 
        public FontManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        // Lấy danh sách font chữ
        public List<string> GetFontFamilies()
        {
            var fontFamilies = new List<string>();
            using (var collection = new InstalledFontCollection())
            {
                foreach (var family in collection.Families)
                {
                    fontFamilies.Add(family.Name);
                }
            }
            return fontFamilies;
        }

        // Thay đổi kiểu font
        public void ChangeFontFamily(string fontFamily)
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                _richTextBox.SelectionFont = new Font(fontFamily, currentFont.Size, currentFont.Style);
            }
        }

        // Thay đổi kích thước font
        public void ChangeFontSize(float fontSize)
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                _richTextBox.SelectionFont = new Font(currentFont.FontFamily, fontSize, currentFont.Style);
            }
        }

        // Thay đổi màu văn bản
        public void ChangeFontColor(Color color)
        {
            _richTextBox.SelectionColor = color;
        }

        // Chuyển văn bản sang in đậm
        public void ToggleBold()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                var newFontStyle = currentFont.Style ^ FontStyle.Bold;
                _richTextBox.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        // Chuyển văn bản sang in nghiêng
        public void ToggleItalic()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                var newFontStyle = currentFont.Style ^ FontStyle.Italic;
                _richTextBox.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        // Chuyển văn bản sang gạch chân
        public void ToggleUnderline()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                var newFontStyle = currentFont.Style ^ FontStyle.Underline;
                _richTextBox.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        // Thay đổi kiểu gạch ngang văn bản
        public void ToggleStrikethrough()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                var newFontStyle = currentFont.Style ^ FontStyle.Strikeout;
                _richTextBox.SelectionFont = new Font(currentFont, newFontStyle);
            }
        }

        // Chuyển văn bản thành chỉ số dưới (Subscript)
        public void ToggleSubscript()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;

                // Nếu đã ở chế độ subscript, trả về kích thước gốc và offset
                if (_richTextBox.SelectionCharOffset < 0)
                {
                    _richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size / 0.75f, currentFont.Style);
                    _richTextBox.SelectionCharOffset = 0;
                }
                // Đặt chế độ subscript
                else if (_richTextBox.SelectionCharOffset == 0) 
                {
                    _richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size * 0.75f, currentFont.Style);
                    _richTextBox.SelectionCharOffset = -6;
                }
            }
        }

        // Chuyển văn bản thành chỉ số trên (Superscript)
        public void ToggleSuperscript()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;

                // Nếu đã ở chế độ superscript, trả về kích thước gốc và offset
                if (_richTextBox.SelectionCharOffset > 0)
                {
                    _richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size / 0.75f, currentFont.Style);
                    _richTextBox.SelectionCharOffset = 0;
                }
                // Đặt chế độ superscript
                else if (_richTextBox.SelectionCharOffset == 0)
                {
                    _richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size * 0.75f, currentFont.Style);
                    _richTextBox.SelectionCharOffset = 12;
                }
            }
        }

        // Thay đổi màu nền (highlight) văn bản
        public void ChangeHighlightColor(Color color)
        {
            _richTextBox.SelectionBackColor = color;
        }

        // Tăng kích thước font
        public void GrowFont()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                float currentSize = currentFont.Size;

                // Tìm vị trí của currentSize trong fontSize array
                int currentIndex = Array.FindIndex(fontSize, size => size >= currentSize);

                // Nếu tìm thấy và còn kích thước lớn hơn trong mảng
                if (currentIndex >= 0 && currentIndex < fontSize.Length - 1)
                {
                    float newSize = fontSize[currentIndex + 1]; // Lấy kích thước kế tiếp
                    _richTextBox.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);

                    // Gọi sự kiện để thông báo kích thước font đã thay đổi
                    FontSizeChanged?.Invoke(newSize);
                }
            }
        }

        // Giảm kích thước font
        public void ShrinkFont()
        {
            if (_richTextBox.SelectionFont != null)
            {
                var currentFont = _richTextBox.SelectionFont;
                float currentSize = currentFont.Size;

                // Tìm vị trí của currentSize trong fontSize array
                int currentIndex = Array.FindIndex(fontSize, size => size >= currentSize);

                // Kiểm tra nếu có kích thước nhỏ hơn trong mảng
                if (currentIndex > 0)
                {
                    float newSize = fontSize[currentIndex - 1]; // Lấy kích thước trước đó
                    _richTextBox.SelectionFont = new Font(currentFont.FontFamily, newSize, currentFont.Style);

                    // Gọi sự kiện để thông báo kích thước font đã thay đổi
                    FontSizeChanged?.Invoke(newSize);
                }
            }
        }
    }
}
