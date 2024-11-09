using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using ListBox = System.Windows.Forms.ListBox;

namespace WordPad
{
    public class InsertManager
    {
        private RichTextBox _richTextBox;

        public Size OriginalImageSize { get; private set; }

        // Kho lưu trữ ảnh gốc với ID duy nhất
        public Dictionary<Guid, Image> originalImages { get; private set; } = new Dictionary<Guid, Image>();

        // Kho lưu trữ vị trị của ảnh trong RichTextBox
        public Dictionary<int, Guid> imagePositions { get; private set; } = new Dictionary<int, Guid>();

        // Khởi tạo với tham chiếu tới RichTextBox
        public InsertManager(RichTextBox richTextBox)
        {
            _richTextBox = richTextBox;
        }

        // Phương thức chèn hình ảnh
        public void InsertImage()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Image img = Image.FromFile(openFileDialog.FileName);
                    OriginalImageSize = img.Size; // Lưu kích thước gốc của ảnh
                    

                    // Tạo ID duy nhất cho ảnh
                    Guid imageId = Guid.NewGuid();

                    // Lưu ảnh gốc vào kho lưu trữ
                    originalImages[imageId] = (Image)img.Clone();

                    // Đánh dấu vị trí chèn ảnh trong RichTextBox
                    int insertPosition = _richTextBox.SelectionStart;

                    // Tạo một bản sao của ảnh để chèn vào RichTextBox
                    Image imageCopy = (Image)img.Clone();

                    Clipboard.SetImage(imageCopy); // Chuyển hình ảnh vào Clipboard

                    // Kiểm tra và chèn hình ảnh
                    if (_richTextBox.CanPaste(DataFormats.GetFormat(DataFormats.Bitmap)))
                    {
                        _richTextBox.Paste();

                        // Lưu vị trí và ID của ảnh
                        imagePositions[insertPosition] = imageId;
                    }
                    else
                    {
                        MessageBox.Show("Failed to insert image.", "Insert Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Phương thức thay đổi hình ảnh
        public void ChangeImage()
        {
            // Tìm kiếm hình ảnh trong RichTextBox (giả sử chỉ có một hình ảnh)
            if (_richTextBox.SelectionLength <= 0)
            {
                MessageBox.Show("Please select an image to change.", "Change Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InsertImage(); // Gọi lại phương thức chèn hình ảnh
        }

        // Hàm để lấy ID của ảnh từ từ điển dựa trên vị trí
        public Guid GetImageAtPosition(int position)
        {
            // Tìm hình ảnh tại vị trí đã cho
            if (imagePositions.TryGetValue(position, out Guid imgID))
            {
                return imgID; // Trả về hình ảnh nếu tìm thấy
            }
            return Guid.Empty; // Không tìm thấy hình ảnh
        }

        // Phương thức thay đổi kích thước hình ảnh
        public void ResizeImage(int newWidth, int newHeight, Guid imageId)
        {
            // Tìm kiếm hình ảnh trong RichTextBox
            if (_richTextBox.SelectionLength <= 0)
            {
                MessageBox.Show("Please select an image to resize.", "Resize Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sao chép nội dung đã chọn vào Clipboard
            _richTextBox.Copy();

            // Lấy vị trí của hình ảnh trong RichTextBox
            int selectionStart = _richTextBox.SelectionStart;
            int selectionLength = _richTextBox.SelectionLength;

            // Lấy ID của hình ảnh tại vị trí đó
            Guid imgId = GetImageAtPosition(selectionStart);

            if (imgId != Guid.Empty) // Kiểm tra nếu ID tồn tại
            {
                if (originalImages.ContainsKey(imageId)) // Kiểm tra nếu có hình ảnh tương ứng với ID đó
                {
                    // Lấy bản gốc của ảnh
                    Image originalImage = originalImages[imageId];

                    // Tạo bản sao của ảnh gốc và thay đổi kích thước
                    Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                    MessageBox.Show($"resizeImage: {newWidth} width {newHeight} height");

                    _richTextBox.Select(selectionStart, selectionLength);
                    _richTextBox.SelectedText = ""; // Xóa hình ảnh cũ

                    // Dán ảnh mới đã resize vào vị trí đó
                    Clipboard.SetImage(resizedImage);
                    _richTextBox.Paste();
                }
            }
            else
            {
                MessageBox.Show("No image found to resize.", "Resize Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Phương thức chèn ngày/giờ
        public void InsertDateTime()
        {
            string dateTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            _richTextBox.AppendText(dateTime);
        }

        public void DisplayDateTimeFormats(ListBox _listBox)
        {
            DateTime now = DateTime.Now;

            // Xóa nội dung hiện tại của _listBox
            _listBox.Items.Clear();

            // Thêm các loại định dạng
            _listBox.Items.Add(now.ToString("MM/d/yyyy"));           // 11/5/2024
            _listBox.Items.Add(now.ToString("MM/d/yy"));            // 11/5/24
            _listBox.Items.Add(now.ToString("M/dd/yy"));              // 11/05/24
            _listBox.Items.Add(now.ToString("MM/dd/yyyy"));           // 11/05/2024
            _listBox.Items.Add(now.ToString("yy/MM/dd"));            // 24/11/05
            _listBox.Items.Add(now.ToString("yyyy-MM-dd"));           // 2024-11-05
            _listBox.Items.Add(now.ToString("dd-MMM-yy"));           // 05-Nov-24
            _listBox.Items.Add(now.ToString("dddd, MMMM dd, yyyy"));   // Tuesday, November 5, 2024
            _listBox.Items.Add(now.ToString("MMMM dd, yyyy"));        // November 5, 2024
            _listBox.Items.Add(now.ToString("dddd, d MMMM, yyyy"));   // Tuesday, 5 November, 2024
            _listBox.Items.Add(now.ToString("d MMMM, yyyy"));         // 5 November, 2024
            _listBox.Items.Add(now.ToString("h:mm:ss tt"));          // 3:08:27 PM
            _listBox.Items.Add(now.ToString("hh:mm:ss tt"));            // 03:08:27 PM 
            _listBox.Items.Add(now.ToString("HH:mm:ss"));            // 15:08:27 

        }

        public void AddObjectTypes(ListBox listBox)
        {
            string[] objectTypes = {
                "Foxit PhantomPDF Document",
                "Microsoft Word 97-2003 Document",
                "Microsoft Word Document",
                "Microsoft Word Macro-Enabled Document",
                "nFoxit PhantomPDF Document",
                "OpenDocument Presentation",
                "OpenDocument Spreadsheet",
                "OpenDocument Text",
                "Microsoft Excel 97-2003 Worksheet",
                "Microsoft Excel Binary Worksheet",
                "Microsoft Excel Chart",
                "Microsoft Excel Macro-Enabled Worksheet",
                "Microsoft Excel Worksheet",
                "Microsoft Worksheet",
                "Microsoft PowerPoint 97-2003 Presentation",
                "Microsoft PowerPoint 97-2003 Slide",
                "Microsoft PowerPoint Macro-Enabled Presentation",
                "Microsoft PowerPoint Macro-Enabled Slide",
                "Microsoft PowerPoint Presentation",
                "Microsoft PowerPoint Slide",
                "Wordpad Document",
                "Math Type 7.0 Equation",
                "Microsoft Graph Chart",
                "Organization Chart Add-in for Microsoft",
                "Package",
                "Paintbrush Picture"
            };

            listBox.Items.AddRange(objectTypes);
        }


    }
}
