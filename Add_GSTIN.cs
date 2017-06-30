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
    public partial class Add_GSTIN : Form
    {
        public Add_GSTIN()
        {
            InitializeComponent();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch
            {
                Environment.Exit(0);
            }
        }
    }
}
