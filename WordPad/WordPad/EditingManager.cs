using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class EditingManager
    {
        private RichTextBox _richTextBox;

        // Khởi tạo với tham chiếu tới RichTextBox
        public EditingManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        // Phương thức tìm kiếm văn bản
        public int FindText(string searchText)
        {
            if (string.IsNullOrEmpty(searchText))
                return -1;

            int startIndex = _richTextBox.Text.IndexOf(searchText, StringComparison.OrdinalIgnoreCase);
            if (startIndex >= 0)
            {
                _richTextBox.Select(startIndex, searchText.Length);
                _richTextBox.Focus();
            }
            return startIndex;
        }

        // Phương thức thay thế văn bản
        public int ReplaceText(string searchText, string replaceText)
        {
            if (string.IsNullOrEmpty(searchText))
                return 0;

            int replacedCount = 0;
            int startIndex = 0;
            _richTextBox.SelectionStart = 0;
            _richTextBox.SelectionLength = 0;

            while ((startIndex = _richTextBox.Text.IndexOf(searchText, startIndex, StringComparison.OrdinalIgnoreCase)) >= 0)
            {
                _richTextBox.Select(startIndex, searchText.Length);
                _richTextBox.SelectedText = replaceText;
                startIndex += replaceText.Length;
                replacedCount++;
            }

            return replacedCount;
        }

        // Chọn tất cả văn bản
        public void SelectAllText()
        {
            _richTextBox.SelectAll();
        }
    }
}
