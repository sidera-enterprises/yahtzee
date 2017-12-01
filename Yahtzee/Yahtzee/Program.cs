using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Yahtzee
{
    public static class Program
    {
        private static Form _startup;
        private static bool _hasExited;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.ThreadException += UnhandledExceptionThrown;

            _hasExited = false;

            try
            {
                if (!IsRunningOnMono())
                {

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);

                    //

                    AppVersionInfo.Year = 2017;
                    AppVersionInfo.DevelopmentState = AppVersionInfo.DevState.Beta;

                    FileSystem fs = new FileSystem();
                    fs.CreateDirectories();
                    fs.WriteFile("help.html", Properties.Resources.HelpManual);

                    _startup = new SplashScreenForm(5,
                                                    new RosterDialog(),
                                                    "Copyright © " + AppVersionInfo.Year
                                                    + " Sidera Enterprises. "
                                                    + "Developed by Jeff Walker. "
                                                    + "Software version "
                                                    + AppVersionInfo.VersionMajorMinorBuild);
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
            catch { }
        }

        public static bool HasExited
        {
            get { return _hasExited; }
        }

        public static bool IsRunningOnMono()
        {
            return Type.GetType("Mono.Runtime") != null;
        }

        public static void Exit()
        {
            _hasExited = true;
            _startup.Close();
        }

        public static void UnhandledExceptionThrown(object sender, ThreadExceptionEventArgs e)
        {
            Form.ActiveForm.Hide();

            ExceptionDialog ed = new ExceptionDialog(e.Exception);
            ed.ShowDialog();
        }
    }
}
