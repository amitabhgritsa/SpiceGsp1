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
    public partial class AfterProceedingToGSTR1 : Form
    {
        public AfterProceedingToGSTR1()
        {
            InitializeComponent();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeforeFillingCheckList bfckck = new BeforeFillingCheckList();
            bfckck.Show();   
        }
    }
}
