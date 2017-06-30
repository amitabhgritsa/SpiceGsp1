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
    public partial class EditItemData : Form
    {
        DataTable dt = new DataTable();
        
        public EditItemData()
        {
            InitializeComponent();
        }

        public void populateDataTable()
        {
            this.dt.Columns.Add("Action");
            this.dt.Columns.Add("Sr.no.");
            this.dt.Columns.Add("VALUE OF THE INVOICE");
            this.dt.Columns.Add("PLACE OF SUPPLY");
            this.dt.Columns.Add("REVERSE CHARGE");
            this.dt.Columns.Add("PROVISIONAL ASSESSMENT");
            this.dt.Columns.Add("ORDER NUMBER");
            this.dt.Columns.Add("ORDER DATE");

            dt.Rows.Add("","1","29600","15","N","Y","A001","17-04-2016");
            dt.Rows.Add("","2", "29600", "15", "N", "Y", "A001", "17-04-2016");

            this.dataGridView1.DataSource = dt;
        }

        private void EditItemData_Load(object sender, EventArgs e)
        {
            this.populateDataTable();
            this.btnEditItemDataOk.Focus();
        }

        private void btnEditItemDataOk_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AfterProceedingToGSTR1 apGSTR = new AfterProceedingToGSTR1();
            apGSTR.Show();
        }
    }
}
