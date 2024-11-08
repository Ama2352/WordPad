using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestingPageSetup;

namespace WordPad
{
    internal class PrintManager
    {
        private PrintDocument printDocument; // Đối tượng PrintDocument để in
        private PageSetupDialog pageSetupDialog;
        private PrintPreviewDialog printPreviewDialog;
        private bool printPageNumber = false; // Cờ để lưu trạng thái "Print Page Number"
        private int currentPageNumber = 1; // Page number tracking
        private Panel panel1;
        private TextBoxBehaviorManager textBoxBehaviorManager;
        public PrintManager(ref Panel P , MainForm MF = null)
        {
            printDocument = new PrintDocument(); // Tạo đối tượng PrintDocument
            pageSetupDialog = new PageSetupDialog();
            // Assign PrintDocument to PageSetupDialog
            pageSetupDialog.Document = printDocument;
            //Print preview dialog
            printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;
            // Attach event handler to PrintPage event to handle drawing
            printDocument.PrintPage += PrintDocument_PrintPage;
            panel1 = P;
            textBoxBehaviorManager = new TextBoxBehaviorManager(P, MF);
        }
        //Print
        #region Print
        public void PrintDoc()
        {
            currentPageNumber = 1; // Reset page number
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

        // Event handler to render the content of the panel on the print page
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Draw the Panel that contains the RichTextBox on the print page
            // Capture the content of the Panel (including the RichTextBox)
            PrintPanel(e);
            if (printPageNumber)
            {
                PrintPageNumber(e);
            }
        }
        private void PrintPanel(PrintPageEventArgs e)
        {
            // Get the graphics object for the print page
            Graphics graphics = e.Graphics;

            // Get the bounds (size and location) of the panel
            Rectangle panelBounds = panel1.Bounds;

            // Adjust the scale for printing based on the paper size (if needed)
            float scaleFactor = 1.0f; // You can change this factor based on the paper size

            // Create a bitmap to hold the visual content of the panel
            using (Bitmap bitmap = new Bitmap(panelBounds.Width, panelBounds.Height))
            {
                // Draw the panel's content onto the bitmap
                panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panelBounds.Width, panelBounds.Height));

                // Calculate the position and size for the printed content
                int printWidth = (int)(panelBounds.Width * scaleFactor);
                int printHeight = (int)(panelBounds.Height * scaleFactor);
                Point printLocation = new Point(0, 0); // Adjust margins as needed

                // Draw the bitmap on the print page
                graphics.DrawImage(bitmap, printLocation.X, printLocation.Y, printWidth, printHeight);
            }

            // Indicate that the print process is complete for this page
            e.HasMorePages = false; // If there are more pages, set this to true
        }
        #endregion
        //Print with page numbers
        private void PrintPageNumber(PrintPageEventArgs e)
        {
            // Font settings for the page number
            Font pageNumberFont = new Font("Arial", 10, FontStyle.Regular);
            string pageNumberText = $"Page {currentPageNumber}";

            // Calculate position for page number (centered in bottom margin)
            float pageNumberX = e.MarginBounds.Left + (e.MarginBounds.Width / 2) - (e.Graphics.MeasureString(pageNumberText, pageNumberFont).Width / 2);
            float pageNumberY = e.MarginBounds.Bottom + 10; // 10 pixels below the bottom margin

            // Draw the page number
            e.Graphics.DrawString(pageNumberText, pageNumberFont, Brushes.Black, new PointF(pageNumberX, pageNumberY));

            currentPageNumber++; // Increment for the next page
        }
        //Page setup
        #region PageSetup
        public void ShowPageSetUp()
        {
            ShowPageSetupDialog();
        }
        public void ShowPageSetupDialog()
        {
            // Nếu người dùng chọn "OK" trong PageSetupDialog
            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
            {
                // Mở hộp thoại bổ sung cho các thiết lập khác
                using (var extraSettingsDialog = new ExtraSettingsDialog())
                {
                    if (extraSettingsDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Lưu cờ printPageNumber từ ExtraSettingsDialog
                        printPageNumber = extraSettingsDialog.PrintPageNumberSelected;
                    }
                }
                AdjustRichTextBoxToPageSetup();
            }
        }
        //Thụt lề
        public void ApllyMargin()
        {
            // Áp dụng margin cho toàn bộ nội dung khi có bất kỳ thay đổi nào
            var pageSettings = printDocument.DefaultPageSettings ?? new PageSettings();
            int leftMargin = pageSettings.Margins.Left;       // Lề trái
            int rightMargin = pageSettings.Margins.Right;       // Lề phải
            int topMargin = pageSettings.Margins.Top;       // Lề trên
            int botMargin = pageSettings.Margins.Bottom;       // Lề dưới
            panel1.Padding = new Padding(leftMargin, topMargin, rightMargin, botMargin);
        }
        //Chỉnh textbox theo page setup
        public void AdjustRichTextBoxToPageSetup()
        {
            var pageSettings = printDocument.DefaultPageSettings ?? new PageSettings();
            // Chỉnh kích thước chuẩn của khổ giấy đang chọn
            int pageWidth = pageSettings.PaperSize.Width;
            int pageHeigth = pageSettings.PaperSize.Height;
            if (pageSettings.Landscape)
            {
                int temp = pageWidth;
                pageWidth = pageHeigth;
                pageHeigth = temp;
            }
            panel1.Width = pageWidth;
            panel1.Height = pageHeigth;
            //Cân bằng textbox sau khi đã thay đổi kích thước
            textBoxBehaviorManager.CenterTextBox();
            //Thụt lề(margin)
            ApllyMargin();
        }
        #endregion
        //Quick print
        public void QuickPrint()
        {
            currentPageNumber = 1; // Reset page number cho mỗi lần in mới

            // Thực hiện in mà không hiển thị hộp thoại
            try
            {
                printDocument.Print(); // In trực tiếp với cài đặt mặc định
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi in nhanh: " + ex.Message);
            }
        }
        //Print preview
        public void ShowPrintPreview()
        {
            currentPageNumber = 1; // Reset page number
            printPreviewDialog.ShowDialog();
        }

    }
}
