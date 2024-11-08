using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        // Tăng thụt lề
        public void IncreaseIndent()
        {
            _richTextBox.SelectionIndent += 20; // Tăng thụt lề 20 pixels
        }

        // Giảm thụt lề
        public void DecreaseIndent()
        {
            _richTextBox.SelectionIndent = Math.Max(0, _richTextBox.SelectionIndent - 20); // Giảm thụt lề 20 pixels nhưng không cho phép giá trị âm
        }

        public enum BulletStyle
        {
            None,             // Không có bullet
            Bullet,           // Dấu chấm
            Numbered,         // Số thứ tự
            Lettered,         // Chữ cái
            RomanNumerals     // Số La Mã
        }

    }
}
