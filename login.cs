using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiceGsp
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GSTR1_Summary gstr = new GSTR1_Summary();
            gstr.Show();
        }

        private void link_forgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot_Password fp = new Forgot_Password();
            fp.Show();
        }

        private void link_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration register = new Registration();
            register.Show();
        }
    }
}

