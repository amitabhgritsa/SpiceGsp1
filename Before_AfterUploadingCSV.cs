﻿using System;
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
    public partial class Before_AfterUploadingCSV : Form
    {
        public Before_AfterUploadingCSV()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            this.tabPage4.ForeColor= Color.Red;
        }

        private void tabPage4_MouseClick(object sender, MouseEventArgs e)
        {
            this.tabPage4.ForeColor = Color.Red;
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Company acompany = new Add_Company();
            acompany.Show();
        }
    }
}
