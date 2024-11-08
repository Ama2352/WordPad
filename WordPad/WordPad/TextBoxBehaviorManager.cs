using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class TextBoxBehaviorManager
    {
        int scrollSpace = 20;   //Khoảng cách lăn chuột
        MainForm mainForm;
        Panel panel1;
        public TextBoxBehaviorManager(Panel P = null, MainForm MF = null)
        {
            panel1 = P;
            mainForm = MF;
        }
        //Cân bằng textbox giữa 2 lể form
        public void CenterTextBox()
        {
            int paddingWidth = (mainForm.Width - panel1.Width) / 2;
            const int paddingHeight = 60; //Chiều cao của block phía trên textbox(menu strip, tabs, icons)
            //MessageBox.Show($"Height: {this.Height}\nWidth: {this.Width}\nLoction: {richTextBox1.Location}");
            panel1.Location = new Point(paddingWidth, paddingHeight);
        }

        //Di chuyển vị trí của panel theo scroll bar
        public void ChangePanelLocat(object sender, ScrollEventArgs e)
        {
            int delta = e.OldValue - e.NewValue;
            if (delta < 0)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - scrollSpace);
            }
            else if (delta > 0)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + scrollSpace);
            }
        }
    }
}
