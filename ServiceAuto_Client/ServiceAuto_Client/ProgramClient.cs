using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceAuto_Client.Controller;
using ServiceAuto_Client.View;

namespace ServiceAuto_Client
{
    internal static class ProgramClient
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ControllerLogin login = new ControllerLogin(0);
            Application.Run(login.GetView());
        }
    }
}
