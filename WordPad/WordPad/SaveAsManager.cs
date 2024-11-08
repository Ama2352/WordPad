using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordPad
{
    internal class SaveAsManager
    {
        SaveManager2 SaveManager = new SaveManager2();
        public void SaveAs()
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
                MainForm.currentFilePath = saveFileDialog.FileName;
                // Luu file voi duong dan moi
                SaveManager.SaveFile(MainForm.currentFilePath);
            }
        }

    }
}
