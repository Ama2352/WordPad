using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class ParagraphManager
    {
        private RichTextBox _richTextBox;

        // Khởi tạo với tham chiếu tới RichTextBox
        public ParagraphManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        // Căn lề trái
        public void AlignLeft()
        {
            _richTextBox.SelectionAlignment = HorizontalAlignment.Left;
        }

        // Căn lề phải
        public void AlignRight()
        {
            _richTextBox.SelectionAlignment = HorizontalAlignment.Right;
        }

        // Căn giữa
        public void AlignCenter()
        {
            _richTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        // Tăng khoảng cách dòng
        public void IncreaseLineSpacing()
        {
            SetLineSpacing(20);
        }

        // Giảm khoảng cách dòng
        public void DecreaseLineSpacing()
        {
            SetLineSpacing(-20);
        }

        // Đặt khoảng cách dòng
        private void SetLineSpacing(int adjustment)
        {
            var selection = _richTextBox.SelectionLength > 0 ? _richTextBox.SelectedRtf : _richTextBox.Rtf;

            selection = Regex.Replace(selection, @"\\sl(\d+)", match =>
            {
                try
                {
                    int currentSpacing = int.Parse(match.Groups[1].Value);
                    int newSpacing = Math.Max(0, currentSpacing + adjustment);
                    return $@"\sl{newSpacing}";
                }
                catch (FormatException)
                {
                    // Xử lý lỗi khi parse
                    return match.Value; // Giữ nguyên giá trị cũ nếu lỗi
                }
            });

            if (!Regex.IsMatch(selection, @"\\sl\d+"))
            {
                // Nếu không tìm thấy \sl, thêm mới 
                selection = selection.Replace(@"{\rtf1", $@"{{\rtf1\sl{Math.Max(0, 240 + adjustment)}");
            }

            _richTextBox.Rtf = selection;
        }
    }
}
