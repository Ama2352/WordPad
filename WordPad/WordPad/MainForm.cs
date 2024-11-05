using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WordPad.ParagraphManager;

namespace WordPad
{
    public partial class MainForm : Form
    {
        private ClipboardManager _clipboardManager;
        private FontManager _fontManager;
        private ParagraphManager _paragraphManager;
        private InsertManager _insertManager;
        private EditingManager _editingManager;

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SettingFontType(FontManager _fontManager)
        {
            // Gán danh sách font cho fontFamilyComboBox
            fontFamilyComboBox.DataSource = _fontManager.GetFontFamilies();

            // Đặt font mặc định cho richTextBox1
            richTextBox1.Font = new Font("Calibri", 11);

            // Đặt font hiển thị mặc định cho fontFamilyComboBox
            fontFamilyComboBox.Text = "Calibri";
        }

        private void SettingFontSize(FontManager _fontManager)
        {
            // Thiết lập kích thước font
            fontSizeComboBox.Items.AddRange(new object[]
            { 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72});

            // Đặt kích thước font mặc định trong fontSizeComboBox
            fontSizeComboBox.SelectedItem = "11";

            // Đặt kích thước font hiển thị mặc định cho fontFamilyComboBox
            fontSizeComboBox.Text = "11";

            // Đăng ký sự kiện FontSizeChanged
            _fontManager.FontSizeChanged += OnFontSizeChanged;
        }

        // Hàm để thiết lập ComboBox Bullet Styles
        private void SetupBulletStyleComboBox()
        {
            // Thêm các kiểu đầu dòng vào ComboBox
            toolStripCombBulletStyles.Items.AddRange(Enum.GetNames(typeof(BulletStyle)));

            // Gắn sự kiện SelectedIndexChanged cho ComboBox
            toolStripCombBulletStyles.SelectedIndexChanged += toolStripCombBulletStyles_SelectedIndexChanged;
        }

        public MainForm()
        {
            InitializeComponent();

            _clipboardManager = new ClipboardManager(richTextBox1); 
            _fontManager = new FontManager(richTextBox1);
            _paragraphManager = new ParagraphManager(richTextBox1);
            _insertManager = new InsertManager(richTextBox1);
            _editingManager = new EditingManager(richTextBox1);

            SettingFontType(_fontManager);
            SettingFontSize(_fontManager);

            this.KeyPreview = true; // Đặt KeyPreview thành true
            this.KeyDown += new KeyEventHandler(MainForm_KeyDown); // Đăng ký sự kiện KeyDown

            // Gọi hàm thiết lập ComboBox cho Bullet Styles
            SetupBulletStyleComboBox();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            // Kiểm tra tổ hợp phím Ctrl + C
            if (e.Control && e.KeyCode == Keys.C)
            {
                _clipboardManager.Copy(); // Gọi phương thức Copy
                e.SuppressKeyPress = true; // Ngăn chặn âm thanh của phím
            }
            // Kiểm tra tổ hợp phím Ctrl + V
            else if (e.Control && e.KeyCode == Keys.V)
            {
                _clipboardManager.Paste(); // Gọi phương thức Paste
                e.SuppressKeyPress = true;
            }
            // Kiểm tra tổ hợp phím Ctrl + X
            else if (e.Control && e.KeyCode == Keys.X)
            {
                _clipboardManager.Cut(); // Gọi phương thức Cut
                e.SuppressKeyPress = true;
            }
        }

        private void btnPasteSpecial_Click(object sender, EventArgs e) // Ví dụ: Button để mở Paste Special
        {
            PasteSpecialForm pasteSpecialForm = new PasteSpecialForm(_clipboardManager);
            pasteSpecialForm.ShowDialog(); // Hiển thị hộp thoại như một modal dialog
        }

        // Clipboard
        private void btnCut_Click(object sender, EventArgs e)
        {
            _clipboardManager.Cut();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            _clipboardManager.Copy();
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            _clipboardManager.Paste();
        }

        // Font
        private void btnBold_Click(object sender, EventArgs e)
        {
            _fontManager.ToggleBold();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            _fontManager.ToggleItalic();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            _fontManager.ToggleUnderline();
        }

        private void fontFamilyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _fontManager.ChangeFontFamily(fontFamilyComboBox.SelectedItem.ToString());
        }

        private void fontSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (float.TryParse(fontSizeComboBox.SelectedItem.ToString(), out float fontSize))
            {
                _fontManager.ChangeFontSize(fontSize);
            }
        }

        // Cập nhật kích cỡ font đang hiển thị nếu có thay đổi về kích thước
        private void OnFontSizeChanged(float newSize)
        {  
            fontSizeComboBox.Text = newSize.ToString();
        }

        private void btnColorPicker_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _fontManager.ChangeFontColor(colorDialog.Color);
                }
            }
        }

        private void strikethroughButton_Click(object sender, EventArgs e)
        {
            _fontManager.ToggleStrikethrough();
        }

        private void subscriptButton_Click(object sender, EventArgs e)
        {
            _fontManager.ToggleSubscript();
        }

        private void superscriptButton_Click(object sender, EventArgs e)
        {
            _fontManager.ToggleSuperscript();
        }

        private void highlightButton_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại màu để chọn màu nền cho highlight
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    _fontManager.ChangeHighlightColor(colorDialog.Color);
                }
            }
        }

        private void growFontButton_Click(object sender, EventArgs e)
        {
            _fontManager.GrowFont();
        }

        private void shrinkFontButton_Click(object sender, EventArgs e)
        {
            _fontManager.ShrinkFont();
        }


        // Paragraph
        private void btnAlignLeft_Click(object sender, EventArgs e)
        {
            _paragraphManager.AlignLeft();
        }

        private void btnAlignCenter_Click(object sender, EventArgs e)
        {
            _paragraphManager.AlignCenter();
        }

        private void btnAlignRight_Click(object sender, EventArgs e)
        {
            _paragraphManager.AlignRight();
        }

        private void btnIncreaseIndent_Click(object sender, EventArgs e)
        {
            _paragraphManager.IncreaseIndent();
        }

        private void btnDecreaseIndent_Click(object sender, EventArgs e)
        {
            _paragraphManager.DecreaseIndent();
        }

        private void toolStripCombBulletStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Insert
        private void btnInsertImage_Click(object sender, EventArgs e)
        {
            _insertManager.InsertImage();
        }

        private void btnInsertDateTime_Click(object sender, EventArgs e)
        {
            _insertManager.InsertDateTime();
        }

        private void insertPictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _insertManager.InsertImage();
        }

        private void resizePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có hình ảnh được chọn
            if (richTextBox1.SelectionStart < richTextBox1.TextLength)
            {
                // Lấy vị trí bắt đầu của lựa chọn
                int selectionStart = richTextBox1.SelectionStart;

                // Tìm ID của hình ảnh tương ứng với vị trí đã chọn
                Guid? imageId = null;
                foreach (var position in _insertManager.imagePositions.Keys.OrderBy(pos => pos))
                {
                    if (position == selectionStart)
                    {
                        imageId = _insertManager.imagePositions[position];
                        break;
                    }
                }

                if(imageId.HasValue)
                {
                    // Truyền kích thước gốc vào ResizeForm
                    using (ResizeForm resizeForm =
                        new ResizeForm(
                            _insertManager.OriginalImageSize.Width,
                            _insertManager.OriginalImageSize.Height,
                            imageId.Value))
                    {
                        if (resizeForm.ShowDialog() == DialogResult.OK)
                        {
                            int newWidth = resizeForm.NewWidth;
                            int newHeight = resizeForm.NewHeight;

                            MessageBox.Show($"Image: {_insertManager.OriginalImageSize.Width} width {_insertManager.OriginalImageSize.Height} height");

                            _insertManager.ResizeImage(newWidth, newHeight, imageId.Value);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No image found at the selected position.", "Resize Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select an image to resize.", "Resize Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void changePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Gọi phương thức thay đổi hình ảnh từ InsertManager
            _insertManager = new InsertManager(richTextBox1);
            _insertManager.ChangeImage();
        }

        private void toolStripDropDownButtonDateAndTime_Click(object sender, EventArgs e)
        {
            using (DateAndTimeForm dateAndTimeForm = new DateAndTimeForm(_insertManager))
            {
                if(dateAndTimeForm.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Select(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
                    richTextBox1.SelectedText = dateAndTimeForm.chosenDateTime;
                }    
            }    
        }


        // Editing
        private void btnFind_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            int resultIndex = _editingManager.FindText(searchText);

            if (resultIndex == -1)
                MessageBox.Show("Text not found.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text;
            string replaceText = txtReplace.Text;
            int replacedCount = _editingManager.ReplaceText(searchText, replaceText);

            MessageBox.Show($"{replacedCount} occurrence(s) replaced.", "Replace", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            _editingManager.SelectAllText();
        }

        private void toolStripDropDownButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButtonPicture_Click(object sender, EventArgs e)
        {

        }

    }
}
