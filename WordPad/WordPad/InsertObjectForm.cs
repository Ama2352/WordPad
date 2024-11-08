using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    public partial class InsertObjectForm : Form
    {
        private InsertManager _insertManager;
        private ClipboardManager _clipboardManager;
        public InsertObjectForm()
        {
            InitializeComponent();
            panelCreateFromFile.Visible = false;
        }

        private void InsertObjectForm_Load(object sender, EventArgs e)
        {
            // Khi form được mở, hiển thị đường dẫn lưu trước đó từ Settings vào txtPath
            txtPath.Text = Properties.Settings.Default.LastPath;
        }

        public InsertObjectForm(InsertManager insertManager, ClipboardManager clipboardManager)
        {
            InitializeComponent();

            _insertManager = insertManager; // Lưu trữ tham chiếu đến Insert Manager
            _clipboardManager = clipboardManager;

            _insertManager.AddObjectTypes(listOptions);



            listOptions.SelectedIndexChanged += ListBoxOptions_SelectedIndexChanged;

        }

        private void ListBoxOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listOptions.SelectedItem != null)
            {
                string selectedOption = listOptions.SelectedItem.ToString();
                var (description, illustration) = _clipboardManager.GetOptionDetails(selectedOption);
                lblOptionDescription.Text = description;
                pictureBoxIllustration.Image = illustration;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
        

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void radCreateNew_CheckedChanged(object sender, EventArgs e)
        {
            if(radCreateNew.Checked)
            {
                listOptions.Visible = true;
                panelCreateFromFile.Visible = false;
            }    
        }

        private void radCreateFromFile_CheckedChanged(object sender, EventArgs e)
        {
            if(radCreateFromFile.Checked)
            {
                listOptions.Visible = false;
                panelCreateFromFile.Visible = true;
                panelCreateFromFile.BringToFront();

                lblOptionDescription.Text = "Inserts the contents of the file as an object into your document so that you " +
                    "may active it using the program which create it.";
                string imagePath = Path.Combine(_clipboardManager._imageDirectory, "paste.png");
                pictureBoxIllustration.Image = _clipboardManager.LoadImage(imagePath);


            }    
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Chọn tệp";
                openFileDialog.Filter = "All Files|*.*"; // Lọc định dạng tệp, có thể thay đổi theo nhu cầu

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu thư mục của đường dẫn tệp vào Settings
                    string selectedDirectory = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                    Properties.Settings.Default.LastPath = selectedDirectory;
                    Properties.Settings.Default.Save(); // Lưu lại setting

                    txtPath.Text = openFileDialog.FileName; // Đưa đường dẫn tệp vào TextBox

                    // Lấy phần mở rộng của tệp
                    string extension = System.IO.Path.GetExtension(openFileDialog.FileName).ToLower();

                    // Xác định loại file dựa trên phần mở rộng
                    string fileType = "Không xác định";
                    switch (extension)
                    {
                        case ".doc":
                        case ".docx":
                            fileType = "Microsoft Word";
                            break;
                        case ".xls":
                        case ".xlsx":
                            fileType = "Microsoft Excel";
                            break;
                        case ".ppt":
                        case ".pptx":
                            fileType = "Microsoft PowerPoint";
                            break;
                        case ".pdf":
                            fileType = "Foxit PhantomPDF";
                            break;
                        case ".png":
                        case ".jpg":
                            fileType = "HTML Document";
                            break;
                        default:
                            break;
                    }

                    // Hiển thị loại file trong lblFileType
                    lblFileType.Text = "File: " + fileType;
                }
            }
        }
    }
}
