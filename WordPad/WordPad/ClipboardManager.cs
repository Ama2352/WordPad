using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class ClipboardManager
    {
        private RichTextBox _richTextBox;

        // Khởi tạo với tham chiếu tới RichTextBox
        public ClipboardManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        // Phương thức Cắt
        public void Cut()
        {
            if (_richTextBox.SelectedText.Length > 0)
            {
                _richTextBox.Cut();
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
            }
            else
            {
                MessageBox.Show("No text selected to copy.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Phương thức Dán
        public void Paste()
        {
            if (Clipboard.ContainsText())
            {
                _richTextBox.Paste();
            }
            else
            {
                MessageBox.Show("Clipboard is empty.", "Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
