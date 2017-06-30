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

       

        private void btn_login_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                // Set focus on control
                control.Focus();
                // Validate causes the control's Validating event to be fired,
                // if CausesValidation is True
                if (!Validate())
                {
                    DialogResult = DialogResult.None;
                    return;
                }
            }
        }

        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                new System.Net.Mail.MailAddress(this.Txt_Email.Text);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("email is empty");
            }
            catch (FormatException)
            {
                //textBox contains no valid mail address
                MessageBox.Show("Email address is not valid");
            }
        }
        
        private void Txt_Password_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_Password.Text))
            {
                MessageBox.Show("Password required!");

            }
            else if (!Regex.IsMatch(Txt_Password.Text, @"((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[^\da-zA-Z]).{8,20})"))
            {
                MessageBox.Show( "Password invalid!");
            }
            else if(Txt_Password.Text.Length < 8 )
            {
                MessageBox.Show("Password must contain at least 8 characters");
               
            }
        }

        private void btn_cross_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

