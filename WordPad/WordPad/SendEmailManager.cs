using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class SendEmailManager
    {
        RichTextBox richTextBox1;
        public SendEmailManager(RichTextBox RTX = null)
        {
            richTextBox1 = RTX;
        }
        public void SendEmail()
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

    }
}
