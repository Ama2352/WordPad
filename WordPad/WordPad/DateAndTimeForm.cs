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
    public partial class DateAndTimeForm : Form
    {
        public string chosenDateTime { get; private set; }
        public DateAndTimeForm(InsertManager insertManager)
        {
            InitializeComponent();

            insertManager.DisplayDateTimeFormats(listBoxDateTime);
        }

        private void DateAndTimeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(listBoxDateTime.SelectedIndex ==  -1) // Nếu không chọn định dạng nào
            {
                MessageBox.Show("Please select a format.", "Confirm Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
            else
            {
                chosenDateTime = listBoxDateTime.SelectedItem.ToString();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
