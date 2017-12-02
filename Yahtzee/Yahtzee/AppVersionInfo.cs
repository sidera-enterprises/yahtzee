using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Yahtzee
{
    public static class AppVersionInfo
    {
        public static string AppName { get { return Assembly.GetExecutingAssembly().GetName().Name; } }
        public static Version Version { get { return Assembly.GetExecutingAssembly().GetName().Version; } }
        public static int Major { get { return Version.Major; } }
        public static int Minor { get { return Version.Minor; } }
        public static int Build { get { return Version.Build; } }
        public static int Revision { get { return Version.Revision; } }
        public static int Year { get; set; }

        public static string VersionMajorMinor { get { return Major + "." + Minor; } }
        public static string VersionMajorMinorBuild
        {
            get
            {
                string ver = Major + "." + Minor;
                string state;
                switch (DevelopmentState)
                {
                    case DevState.Alpha: state = " alpha"; break;
                    case DevState.Beta: state = " beta"; break;
                    default: state = ""; break;
                }
                return Major + "." + Minor + state + " build " + Build;
            }
        }
        public static string VersionFull { get { return Major + "." + Minor + "." + Build + "." + Revision; } }

        public static DevState DevelopmentState { get; set; }

        public enum DevState { Alpha, Beta, Stable }
    }
}
