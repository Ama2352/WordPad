using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 5.0f) // Giới hạn phóng to
            {
                richTextBox1.ZoomFactor += 0.1f; // Tăng kích thước phông chữ
            }
        }
        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.1f) // Giới hạn thu nhỏ
            {
                richTextBox1.ZoomFactor -= 0.1f; // Giảm kích thước phông chữ
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int charCount = richTextBox1.Text.Length; // Số ký tự
            int lineCount = richTextBox1.Lines.Length; // Số dòng
            string measurementUnit = comboBoxMeasurement.SelectedItem.ToString(); // Đơn vị đo

            // Cập nhật thông tin vào StatusBar
            toolStripStatusLabel1.Text = $"Characters: {charCount}, Lines: {lineCount}, Measurement Unit: {measurementUnit}";
        }
        private void panelRuler_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // Làm sạch nền
            Pen pen = new Pen(Color.Black); // Đường kẻ

            float unitSize = 5f; // Đơn vị mặc định là cm

            // Điều chỉnh kích thước đơn vị nếu chọn inch
            if (comboBoxMeasurement.SelectedItem.ToString() == "Inches (in)")
            {
                unitSize = 2.54f; // 1 inch = 2.54 cm
            }
            float panelWidth = panelRuler.Width;

            // Vẽ các đường kẻ trên ruler
            for (int i = 0; i <= panelWidth; i += 10) // Vẽ mỗi 10 đơn vị
            {
                float x = i * unitSize; // Tính vị trí x
                g.DrawLine(pen, x, 5, x, 20); // Đường kẻ đứng
                g.DrawString(i.ToString(), this.Font, Brushes.Black, x - 5, 22); // Ghi số lên ruler
            }

            pen.Dispose(); // Giải phóng pen
        }
        private void comboBoxMeasurement_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelRuler.Invalidate(); // Làm mới panel để vẽ lại
            richTextBox1_TextChanged(sender, e); // Cập nhật Status Bar
        }
        private void checkBoxWordWrap_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = checkBoxWordWrap.Checked; // Bật/Tắt Word Wrap
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Thêm các đơn vị đo vào ComboBox
            comboBoxMeasurement.Items.Add("Centimeters (cm)");
            comboBoxMeasurement.Items.Add("Inches (in)");
            comboBoxMeasurement.SelectedIndex = 0; // Chọn mặc định là cm
        }
        private void richTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateStatusBar();
        }
        private void UpdateStatusBar()
        {
            // Lấy số dòng
            int lineCount = richTextBox1.Lines.Length;
            // Lấy số ký tự
            int charCount = richTextBox1.Text.Length;
            // Lấy số dòng hiện tại
            int currentLine = richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1;
            // Tính toán số cột
            int currentColumn = richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexFromLine(currentLine - 1) + 1;

            // Cập nhật thông tin lên status bar
            toolStripStatusLabel1.Text = $"Lines: {lineCount} | Characters: {charCount} | Line: {currentLine}, Column: {currentColumn}";
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Đặt chiều rộng của panelRuler để nó dài theo chiều rộng của form  
            panelRuler.Width = this.ClientSize.Width; // Đặt chiều rộng  
            panelRuler.Location = new Point(0, 0); // Đặt ở góc trên bên trái  
        }

    }
}
