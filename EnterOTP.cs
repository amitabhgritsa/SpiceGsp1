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
    public partial class EnterOTP : Form
    {
        public EnterOTP()
        {
            InitializeComponent();
        }

        private void EnterOTP_Load(object sender, EventArgs e)
        {
            this.textBox1.Focus();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox2.Focus();
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox3.Focus();
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox4.Focus();
        }

        private void textBox4_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox5.Focus();
        }

        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            this.textBox6.Focus();
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            this.button1.Focus();
        }
    }
}
