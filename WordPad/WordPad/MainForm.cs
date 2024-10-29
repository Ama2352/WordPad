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


        public MainForm()
        {
            InitializeComponent();
            _clipboardManager = new ClipboardManager(richTextBox1); 
            _fontManager = new FontManager(richTextBox1);
            _paragraphManager = new ParagraphManager(richTextBox1);
            _insertManager = new InsertManager(richTextBox1);
            _editingManager = new EditingManager(richTextBox1);

            // Thiết lập font chữ
            fontFamilyComboBox.DataSource = _fontManager.GetFontFamilies();

            // Thiết lập kích thước font
            fontSizeComboBox.Items.AddRange(new object[] { 8, 10, 12, 14, 16, 18, 20, 22, 24, 26 });
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

        private void btnIncreaseLineSpacing_Click(object sender, EventArgs e)
        {
            _paragraphManager.IncreaseLineSpacing();
        }

        private void btnDecreaseLineSpacing_Click(object sender, EventArgs e)
        {
            _paragraphManager.DecreaseLineSpacing();
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
    }
}
