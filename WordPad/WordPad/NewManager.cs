using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class NewManager
    {

        RichTextBox richTextBox1;
        SaveManager saveManager;
        MainForm mainForm;
        public NewManager(RichTextBox RTX ,MainForm MF = null)
        {
            richTextBox1 = RTX;
            mainForm = MF;
            saveManager = new SaveManager(RTX);
        }
        public void CreatNew()
        {
            // Kiểm tra xem có cần lưu thay đổi trước khi tạo tài liệu mới
            if (ConfirmSaveChanges())
            {
                richTextBox1.Clear(); // Xóa nội dung hiện tại trong RichTextBox
                SaveManager.currentFilePath = string.Empty; // Đặt lại đường dẫn file hiện tại
                MainForm.isTextChanged = false; // Đặt lại trạng thái thay đổi
            }
        }
        // Xác nhận người dùng có muốn lưu thay đổi trước khi thực hiện thao tác
        public bool ConfirmSaveChanges()
        {
            // Nếu có thay đổi chưa lưu
            if (MainForm.isTextChanged)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show(
                    "Bạn có muốn lưu thay đổi trước khi đóng không?", // Thông điệp hiển thị
                    "Lưu thay đổi", // Tiêu đề hộp thoại
                    MessageBoxButtons.YesNoCancel, // Các nút lựa chọn
                    MessageBoxIcon.Warning // Biểu tượng cảnh báo
                );

                // Nếu người dùng chọn "Yes", gọi phương thức lưu file
                if (result == DialogResult.Yes)
                {
                    saveManager.Save(mainForm, EventArgs.Empty);
                }
                // Nếu chọn "Cancel", hủy thao tác
                else if (result == DialogResult.Cancel)
                {
                    return false; // Không thực hiện thao tác
                }
            }
            return true; // Nếu không có thay đổi hoặc người dùng chọn "No"
        }

    }
}
