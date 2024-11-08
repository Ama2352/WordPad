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
    public partial class PasteSpecialForm : Form
    {
        private ClipboardManager _clipboardManager;
        public bool DisplayAsIcon { get; private set; } // Thuộc tính để lưu trạng thái của DisplayAsIcon
        private Timer _clipboardCheckTimer;


        public PasteSpecialForm() { }
        public PasteSpecialForm(ClipboardManager clipboardManager)
        {
            InitializeComponent();

            _clipboardManager = clipboardManager; // Lưu trữ tham chiếu đến ClipboardManager
            LoadPasteOptions();

            chkDisplayAsIcon.Enabled = false;

            InitializeRadioButtons(); // Gọi hàm khởi tạo radio buttons

            listOptions.SelectedIndexChanged += ListBoxOptions_SelectedIndexChanged;

            InitializeTimer(); // Gọi hàm khởi tạo timer

        }

        private void InitializeRadioButtons()
        {
            // Đặt mặc định vào ô Paste
            radPaste.Checked = true;
            listOptions.Enabled = true;

            // Xử lý sự kiện khi thay đổi trạng thái của radio button
            radPaste.CheckedChanged += RadioButton_CheckedChanged;
            radPasteLink.CheckedChanged += RadioButton_CheckedChanged;
        }

        public void InitializeTimer()
        {
            // Khởi tạo và cấu hình Timer
            _clipboardCheckTimer = new Timer();
            _clipboardCheckTimer.Interval = 1000; // Kiểm tra mỗi giây (1000 ms)
            _clipboardCheckTimer.Tick += ClipboardCheckTimer_Tick;
            _clipboardCheckTimer.Start();
        }

        private void ClipboardCheckTimer_Tick(object sender, EventArgs e)
        {
            LoadPasteOptions(); // Cập nhật lại các tùy chọn dán
            UpdateSourceDisplay();
        }

        private void PasteSpecialForm_Load(object sender, EventArgs e)
        {

        }

        private void LoadPasteOptions()
        {
            // Lấy các tùy chọn dán từ clipboard
            var options = _clipboardManager.GetPasteOptions();

            // So sánh danh sách mới với danh sách hiện tại để tránh làm mới nếu không cần thiết
            if (!listOptions.Items.Cast<string>().SequenceEqual(options))
            {
                listOptions.Items.Clear(); // Xóa các mục cũ
                foreach (var option in options)
                {
                    listOptions.Items.Add(option);
                }
            }
        }

        private void ListBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOptions.SelectedItem != null)
            {
                string selectedOption = listOptions.SelectedItem.ToString();
                var (description, illustration) = _clipboardManager.GetOptionDetails(selectedOption);
                lblDescription.Text = description;
                picbIllustration.Image = illustration;

                // Bật "Display As Icon" nếu lựa chọn là "Wordpad Document"
                chkDisplayAsIcon.Enabled = selectedOption == "Wordpad Document";
                if (!chkDisplayAsIcon.Enabled)
                {
                    chkDisplayAsIcon.Checked = false;
                }
            }
        }

        // Phương thức cập nhật loại nguồn dữ liệu trong Clipboard
        private void UpdateSourceDisplay()
        {
            if (_clipboardManager.IsCopiedFromApplication) // Kiểm tra định dạng của Wordpad
            {
                lblSourceDisplay.Text = "Wordpad Document";
            }
            else if (Clipboard.ContainsData("Word.Document")) // Kiểm tra định dạng của Microsoft Word
            {
                lblSourceDisplay.Text = "Microsoft Word Document";
            }
            else
            {
                lblSourceDisplay.Text = "Unknown Source"; // Không phải Word hoặc WordPad
            }
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radPaste.Checked)
            {
                listOptions.Enabled = true; // Bật các lựa chọn trong listbox nếu chọn "Paste"
            }
            else if (radPasteLink.Checked)
            {
                listOptions.Enabled = _clipboardManager.CanPasteLink(); // Bật hoặc tắt dựa trên điều kiện Paste Link
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            if (listOptions.Enabled && listOptions.SelectedItem == null)
            {
                MessageBox.Show("Please select a paste option.", "Paste Special", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedOption = listOptions.SelectedItem?.ToString();
            DisplayAsIcon = chkDisplayAsIcon.Checked;
            _clipboardManager.PasteSpecial(selectedOption, DisplayAsIcon);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Dừng Timer khi hộp thoại đóng
            _clipboardCheckTimer.Stop();
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
