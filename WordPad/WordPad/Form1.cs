using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class Form1 : Form
    {
        // Bien luu duong dan file hien tai
        private string currentFilePath = string.Empty;
        private bool isTextChanged = false; // Biến theo dõi thay đổi nội dung trong RichTextBox
        private PrintDocument printDocument; // Đối tượng PrintDocument để in

        public Form1()
        {
            InitializeComponent();
            printDocument = new PrintDocument(); // Tạo đối tượng PrintDocument
        }
        //Open
        private void openToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Mo hop thoai de chon file, chi hien thi cac file .txt va .rtf
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                // Chi hien thi cac file co dinh dang .txt hoac .rtf trong hop thoai
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf",
                Title = "Open File" // Tieu de cua hop thoai
            };

            // Kiem tra neu nguoi dung chon file va bam OK trong hop thoai
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lay duong dan cua file duoc chon
                string filePath = openFileDialog.FileName;

                // Neu file co duoi .rtf thi tai? noi dung voi RichTextBoxStreamType.RichText
                if (Path.GetExtension(filePath).ToLower() == ".rtf")
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.RichText);
                }
                else // Neu khong thi tai noi dung voi dinh dang PlainText
                {
                    richTextBox1.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                }

                // Cap nhat bien currentFilePath voi duong dan file vua duoc mo
                currentFilePath = filePath;
            }
        }
        
        //Save
        private void SaveFile(string filePath)
        {
            // Kiem tra dinh dang cua file dua tren phan mo rong (duoi file)
            if (Path.GetExtension(filePath).ToLower() == ".rtf")
            {
                // Luu noi dung RichTextBox vao file dinh dang RichText
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.RichText);
            }
            else
            {
                // Luu noi dung RichTextBox vao file dinh dang PlainText
                richTextBox1.SaveFile(filePath, RichTextBoxStreamType.PlainText);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiem tra neu currentFilePath khong rong, nghia la file da duoc mo hoac luu truoc do
            if (!string.IsNullOrEmpty(currentFilePath))
            {
                // Goi phuong thuc SaveFile voi duong dan hien tai
                SaveFile(currentFilePath);
            }
            else
            {
                // Neu chua co duong dan (lan dau luu) thi goi chuc nang "Save As"
                saveAsToolStripMenuItem_Click(sender, e);
            }
        }
        //Save as
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Mo hop thoai de chon duong dan va ten file muon luu, chi luu duoi .txt hoac .rtf
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf", // Chi luu file dinh dang .txt hoac .rtf
                Title = "Save As" // Tieu de cua hop thoai
            };

            // Neu nguoi dung chon vi tri va ten file de luu
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Cap nhat currentFilePath voi duong dan file duoc chon
                currentFilePath = saveFileDialog.FileName;
                // Luu file voi duong dan moi
                SaveFile(currentFilePath);
            }
        }
        //New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có cần lưu thay đổi trước khi tạo tài liệu mới
            if (ConfirmSaveChanges())
            {
                richTextBox1.Clear(); // Xóa nội dung hiện tại trong RichTextBox
                currentFilePath = string.Empty; // Đặt lại đường dẫn file hiện tại
                isTextChanged = false; // Đặt lại trạng thái thay đổi
            }
        }
        // Xác nhận người dùng có muốn lưu thay đổi trước khi thực hiện thao tác
        private bool ConfirmSaveChanges()
        {
            // Nếu có thay đổi chưa lưu
            if (isTextChanged)
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
                    saveToolStripMenuItem_Click(this, EventArgs.Empty);
                }
                // Nếu chọn "Cancel", hủy thao tác
                else if (result == DialogResult.Cancel)
                {
                    return false; // Không thực hiện thao tác
                }
            }
            return true; // Nếu không có thay đổi hoặc người dùng chọn "No"
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            isTextChanged = true; // Đánh dấu rằng nội dung đã thay đổi
        }
        //Print
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //PrintDocument printDocument = new PrintDocument(); // Tạo đối tượng in mới
            printDocument.PrintPage += new PrintPageEventHandler(PrintPage); // Đăng ký sự kiện in trang

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument // Gán tài liệu cho hộp thoại in
            };

            // Hiển thị hộp thoại in, nếu người dùng xác nhận thì thực hiện in
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print(); // Thực hiện in tài liệu
            }
        }
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            // Vẽ nội dung của RichTextBox lên trang in tại tọa độ (100, 100)
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 100, 100);
        }


        //Exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra có cần lưu thay đổi trước khi thoát
            if (ConfirmSaveChanges())
            {
                Application.Exit(); // Thoát ứng dụng
            }
        }
        //Page setup
        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PageSetupDialog pageSetupDialog = new PageSetupDialog();
            pageSetupDialog.Document = printDocument;

            // Hiển thị hộp thoại Page Setup
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // Cập nhật các thiết lập giấy và lề
                UpdateRichTextBoxLayout();
                MessageBox.Show("Thiết lập trang đã được cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // Cập nhật kích thước RichTextBox dựa trên thiết lập trang
        private void UpdateRichTextBoxLayout()
        {
            // Lấy kích thước giấy và lề từ Page Setup
            var pageSettings = printDocument.DefaultPageSettings;
            int pageWidth = pageSettings.PaperSize.Width;
            int pageHeight = pageSettings.PaperSize.Height;

            // Điều chỉnh chiều ngang và chiều dọc dựa trên orientation
            if (pageSettings.Landscape)
            {
                richTextBox1.Width = pageHeight - pageSettings.Margins.Left - pageSettings.Margins.Right;
                richTextBox1.Height = pageWidth - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            }
            else
            {
                richTextBox1.Width = pageWidth - pageSettings.Margins.Left - pageSettings.Margins.Right;
                richTextBox1.Height = pageHeight - pageSettings.Margins.Top - pageSettings.Margins.Bottom;
            }

            // Đặt lại anchor sau khi thiết lập kích thước mới
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
        }
        //Send in email (cần test thêm)
        private void sendInEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage(); // Tạo một đối tượng mail mới
                mail.From = new MailAddress("your_email@example.com"); // Địa chỉ email của người gửi
                mail.To.Add("recipient_email@example.com"); // Địa chỉ email của người nhận
                mail.Subject = "Document from WordPad"; // Tiêu đề email
                mail.Body = richTextBox1.Text; // Nội dung email là nội dung trong RichTextBox

                SmtpClient smtpClient = new SmtpClient("smtp.example.com"); // Địa chỉ SMTP server
                smtpClient.Port = 587; // Cổng SMTP
                smtpClient.Credentials = new System.Net.NetworkCredential("your_email@example.com", "your_password"); // Thông tin xác thực
                smtpClient.EnableSsl = true; // Bật SSL

                smtpClient.Send(mail); // Gửi email
                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi gửi email: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //About
        private void aboutWordPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WordPad Clone\nPhiên bản 1.0\nĐược phát triển bởi Nhóm 7",
                "Giới thiệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
