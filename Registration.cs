using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiceGsp
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Txt_FirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Txt_LastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void Txt_Company_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Txt_Company.Text))
            {
                MessageBox.Show("Company name can not be empty");
            }
        }
    }
}
