using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Clinic_Management_System
{
    static class Program
    {
        public static string user_id;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmServerSetting frm = new frmServerSetting();
            //add_employee f = new add_employee();
           // Application.Run(new frm_Open_Visit());
          // Application.Run(new frm_About_Us());
            //MessageBox.Show(Properties.Settings.Default.Server);
            if (Properties.Settings.Default.Server == "")
            {
                Application.Run(frm);
                Application.Run(new Log_in());

            }
            else
            {
                Application.Run(new Log_in());
            }
        
        }
    }
}
