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
    public partial class ResizeForm : Form
    {
        private int _originalWidth;
        private int _originalHeight;
        public int NewWidth { get; private set; }
        public int NewHeight { get; private set; }

        private bool aspectRatioLocked = true;

        private static bool isFirstLoad = true; // Biến để theo dõi lần mở form

        private bool _isUpdating = false; // Biến để ngăn vòng lặp

        private static decimal resizedNumericHorizontal;
        private static decimal resizedNumericVertical;

        private void ResizeForm_Load(object sender, EventArgs e)
        {
            if (isFirstLoad)
            {
                // Đánh dấu rằng form đã được mở sau lần mở đầu tiên
                isFirstLoad = false; 
            }
        }

        public ResizeForm(int originalWidth, int originalHeight)
        {
            InitializeComponent();
            _originalWidth = originalWidth;
            _originalHeight = originalHeight;

            if(isFirstLoad) 
            {
                numericUpDownHorizontal.Value = 100; // 100% cho kích thước gốc
                numericUpDownVertical.Value = 100; // 100% cho kích thước gốc
            }
            else
            {
                numericUpDownHorizontal.Value = resizedNumericHorizontal;
                numericUpDownVertical.Value = resizedNumericVertical;
            }    

            chkLockAspectRatio.Checked = true;

            numericUpDownHorizontal.ValueChanged += NumericUpDown_ValueChanged;
            numericUpDownVertical.ValueChanged += NumericUpDown_ValueChanged;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            // Gọi lại hàm ValueChanged để đảm bảo NewWidth và NewHeight được cập nhật
            NumericUpDown_ValueChanged(null, null);

            resizedNumericHorizontal = numericUpDownHorizontal.Value;
            resizedNumericVertical = numericUpDownVertical.Value;

            this.DialogResult = DialogResult.OK; // Trả về kết quả OK
            this.Close(); // Đóng form
        }

        private void checkBoxLockAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
           aspectRatioLocked = chkLockAspectRatio.Checked; // Lưu trạng thái của Checkbox
        }

        private void NumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (_isUpdating) return; // Nếu đang cập nhật thì không làm gì cả

            _isUpdating = true; // Bắt đầu cập nhật

            NewWidth = (int)(_originalWidth * (numericUpDownHorizontal.Value / 100));
            NewHeight = (int)(_originalHeight * (numericUpDownVertical.Value / 100));

            if (aspectRatioLocked)
            {
                if (sender == numericUpDownHorizontal)
                {
                    numericUpDownVertical.Value = numericUpDownHorizontal.Value; // Trạng thái đang cập nhật
                }
                else if (sender == numericUpDownVertical)
                {
                    numericUpDownHorizontal.Value = numericUpDownVertical.Value; // Trạng thái đang cập nhật
                }
            }    
            _isUpdating = false; // Kết thúc cập nhật
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Trả về kết quả Cancel
            this.Close(); // Đóng form
        }
    }
}
