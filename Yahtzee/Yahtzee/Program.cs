using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Yahtzee
{
    public static class Program
    {
        private static Form _startup;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            if (!IsRunningOnMono())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                _startup = new StartupDialog();
                Application.Run(_startup);
            }
            else
            {
                MessageBox.Show("This application currently does not support "
                              + "Mono. We recommend that you run this "
                              + "application on Windows 7 or later."
                              + "\n\n"
                              + "We apologize for the inconvenience.",
                                "Error starting Yahtzee!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public static bool IsRunningOnMono()
        {
            return Type.GetType("Mono.Runtime") != null;
        }

        public static void Exit()
        {
            _startup.Close();
        }
    }
}
