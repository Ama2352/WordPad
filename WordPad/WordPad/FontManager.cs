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
    }
}
