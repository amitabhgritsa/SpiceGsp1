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
    public partial class DataItemOfCSV : Form
    {
        public DataItemOfCSV()
        {
            InitializeComponent();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditItemData edata = new EditItemData();
            edata.Show();
        }
    }
}
