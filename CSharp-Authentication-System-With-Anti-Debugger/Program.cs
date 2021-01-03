using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLEye_v1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            OnProgramStart.Initialize("SQLeye", "217708", "EboDokvxNM0a2DYLFvuHnpsyW2C1wV8AgY8", "1.1");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Login());


            AntiDumps.AntiDump();
            //if (API.Login(Properties.Settings.Default.dusername, Properties.Settings.Default.dpassword))
            //{
            //    Application.Run(new Main());
            //}



        }

    }
}
