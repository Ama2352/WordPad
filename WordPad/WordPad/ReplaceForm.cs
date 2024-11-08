using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class ReplaceForm : Form
    {
        private EditingManager editingManager;
        public ReplaceForm(EditingManager editingManager)
        {
            InitializeComponent();
            this.editingManager = editingManager;
        }

        private void ReplaceForm_Load(object sender, EventArgs e)
        {

        }

        private void btnFindNext_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển trong ReplaceForm
            string searchText = txtSearchText.Text;
            bool matchCase = chkMatchCase.Checked;
            bool matchWholeWord = chkMatchWholeWordOnly.Checked;

            // Gọi hàm FindText trong EditingManager để thực hiện tìm kiếm
            editingManager.FindText(searchText, matchCase, matchWholeWord);
        }

        // Khi đóng cửa sổ tìm kiếm bằng nút Close
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Gọi hàm để xóa bỏ các từ đã được làm nổi bật
            editingManager.ClearPreviousHighlight();

            this.Close();  // Đóng form FindForm
        }

        // Khi đóng cửa sổ tìm kiếm bằng cách nhấn nút "Esc"
        private void ReplaceForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // Khi bấm phím Esc, sẽ xóa bỏ màu nền và đóng form FindForm
                editingManager.ClearPreviousHighlight();
                this.Close();  // Đóng form FindForm
            }
        }

        // Khi form đóng (bao gồm nhấn "X")
        private void ReplaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Xóa màu nền của các từ đã tìm thấy trong MainForm khi đóng FindForm
            editingManager.ClearPreviousHighlight();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển trong ReplaceForm
            string searchText = txtSearchText.Text;
            string replaceText = txtReplaceText.Text;
            bool matchCase = chkMatchCase.Checked;
            bool matchWholeWord = chkMatchWholeWordOnly.Checked;

            editingManager.FindAndReplace(searchText, replaceText, matchCase, matchWholeWord);
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            // Lấy giá trị từ các điều khiển trong ReplaceForm
            string searchText = txtSearchText.Text;
            string replaceText = txtReplaceText.Text;
            bool matchCase = chkMatchCase.Checked;
            bool matchWholeWord = chkMatchWholeWordOnly.Checked;

            editingManager.ReplaceAll(searchText, replaceText, matchCase, matchWholeWord);
        }
    }
}
