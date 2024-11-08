using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestingPageSetup
{
    public partial class ExtraSettingsDialog : Form
    {
        private CheckBox chkPrintPageNumber;
        private Button btnOK;
        private Button btnCancel;

        public bool PrintPageNumberSelected => chkPrintPageNumber.Checked;

        public ExtraSettingsDialog()
        {
            this.Text = "Additional Settings";
            this.Size = new System.Drawing.Size(300, 150);

            // Checkbox Print Page Number
            chkPrintPageNumber = new CheckBox
            {
                Text = "Print Page Number",
                Location = new System.Drawing.Point(20, 20),
                AutoSize = true
            };
            this.Controls.Add(chkPrintPageNumber);

            // Nút OK và Cancel
            btnOK = new Button { Text = "OK", DialogResult = DialogResult.OK, Location = new System.Drawing.Point(50, 70) };
            btnCancel = new Button { Text = "Cancel", DialogResult = DialogResult.Cancel, Location = new System.Drawing.Point(150, 70) };
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
        }
    }
}
