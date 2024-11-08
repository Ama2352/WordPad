using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class AboutManager
    {
        private void aboutWordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WordPad Clone\nPhiên bản 1.0\nĐược phát triển bởi Nhóm 7",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
