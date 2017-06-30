using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpiceGsp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new HomeScreen());
            //Application.Run(new Before_AfterUploadingCSV());
            //Application.Run(new Add_csv());
            //Application.Run(new GSTR1_Summary());
            //Application.Run(new BeforeFillingCheckList());
            Application.Run(new login());
            //Application.Run(new Registration());
            //Application.Run(new Forgot_Password());
            //Application.Run(new Add_Company());
            //Application.Run(new Add_GSTIN());
            //Application.Run(new AfterProceedingToGSTR1());
            //Application.Run(new DataItemOfCSV());

        }      
            
    }
}
