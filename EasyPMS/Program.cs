using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EasyPMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Initialize("log.txt", false, true);
            /*if (!LicenseValidator.Vailidate())
            {
                Log.Error("License validation failed.");
                return;
            }*/
            LicenseValidator.IsUpdateVailable();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
