using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingFIeld
{
    public partial class Form1 : Form
    {
        int scrollSpace = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int delta = e.OldValue - e.NewValue;    
            //Kiểm tra panel có dụng bot hoặc top chưa
            bool isBot = false;
            bool isTop = false;
            if(panel1.Bottom <= ClientSize.Height)
                isBot = true;
            else if (panel1.Top >= ClientSize.Height)
                isTop = true;
            if(isBot == false && isTop == false)
            {
                //delta < 0 --> Đang lăn chuột xuống --> Đẩy panel lên (0 ở trên cùng --> Trừ)
                if(delta < 0)
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - scrollSpace);
                }
                //delta > 0 --> Đang lăn chuột lên --> Đẩy panel xuống
                else if (delta > 0)
                {
                    panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + scrollSpace);
                }
            }
            //Chạm bot thì chỉ cho lăn lên
            else if (isBot)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + scrollSpace);
            }
            //Chạm top thì chỉ cho lăn xuống
            else if(isTop)
            {
                panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - scrollSpace);
            }
        }
        Size oldSize;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Panel location: {panel1.Location}\nScrollbar value: {vScrollBar1.Value}" +
                $"\nPanel top: {panel1.Top}\nPanel bot: {panel1.Bottom}");
            oldSize = richTextBox1.Size;
            richTextBox1.Size = new Size(100,100);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Size = oldSize;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vScrollBar1.Maximum = panel1.Height / scrollSpace + 50;
            //vScrollBar1.Maximum = 0;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            //vScrollBar1.Maximum = panel1.Height / ClientSize.Height + 10;
            //MessageBox.Show($"scrollbar max: {vScrollBar1.Maximum}\n panel height: {panel1.Height}\n " +
                //$"client size: {ClientSize.Height}");
        }
        //Hàm tính chiều cao nội dung text box
        private int GetRichTextBoxContentHeight(RichTextBox rtb)
        {
            // Lấy vị trí Y của ký tự cuối cùng trong RichTextBox
            int lastCharIndex = rtb.Text.Length - 1;
            if (lastCharIndex < 0) return 0;

            // Lấy tọa độ của ký tự cuối cùng và tính chiều cao tổng cộng
            int contentHeight = rtb.GetPositionFromCharIndex(lastCharIndex).Y + rtb.Font.Height;
            return contentHeight;
        }
        //Dựa vào chiều cao nội dung thay đổi maximum value của scroll bar
        private void UpdateScrollBarMaximum()
        {
            // Lấy chiều cao nội dung của RichTextBox
            int contentHeight = GetRichTextBoxContentHeight(richTextBox1);
            //Chiều cao của vùng hiển thi bảng trắng
            //Khi chiều cao nội dung vượt quá phạm vi này sẽ xuất hiện scroll bar và sẽ chỉnh maximum value tương ứng
            //theo chiều cao nội dung
            int displayHeight = ClientSize.Height - panel1.Location.Y - panel1.Padding.Top - richTextBox1.Font.Height;

            if (contentHeight > displayHeight)
            {
                vScrollBar1.Maximum = contentHeight - displayHeight;
                vScrollBar1.Enabled = true;
            }
            else
            {
                vScrollBar1.Enabled = false; // Không cần thanh cuộn nếu nội dung nhỏ hơn vùng hiển thị
            }

            // Thiết lập bước cuộn lớn và nhỏ
            vScrollBar1.LargeChange = displayHeight;
            vScrollBar1.SmallChange = 20;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateScrollBarMaximum();
        }
    }
}
