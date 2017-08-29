using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Yahtzee
{
    class FileSystem
    {
        public FileSystem(string appName) : this(Application.StartupPath, appName) { }
        public FileSystem(string root, string appName)
        {
            RootDir = root;
            AppDir = RootDir + "\\Sidera\\" + appName;
        }

        public string RootDir { get; private set; }
        public string SideraDir { get { return RootDir + "\\Sidera"; } }
        public string AppDir { get; private set; }
        public string ConfigDir { get { return AppDir + "\\config"; } }

        #region Directory methods
        public bool DirectoryExists(string dirPath)
        {
            return Directory.Exists(RootDir + "\\" + dirPath);
        }

        public bool CreateDirectories()
        {
            try
            {
                Directory.CreateDirectory(RootDir);
                Directory.CreateDirectory(SideraDir);
                Directory.CreateDirectory(AppDir);
                Directory.CreateDirectory(ConfigDir);

                return true;
            }
            catch { return false; }
        }

        public bool CreateDirectory(string dirPath)
        {
            try
            {
                Directory.CreateDirectory(RootDir + "\\" + dirPath);

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region File methods
        public bool FileExists(string filePath)
        {
            return File.Exists(RootDir + "\\" + filePath);
        }

        public bool ConfigFileExists(string filePath)
        {
            return File.Exists(ConfigDir + "\\" + filePath);
        }

        public bool WriteConfigFile(string fileName, string contents)
        {
            try
            {
                File.WriteAllText(ConfigDir + "\\" + fileName, contents);

                return true;
            }
            catch { return false; }
        }

        public string ReadConfigFile(string fileName)
        {
            return File.ReadAllText(ConfigDir + "\\" + fileName);
        }

        public bool DeleteConfigFile(string fileName)
        {
            try
            {
                File.Delete(ConfigDir + "\\" + fileName);

                return true;
            }
            catch { return false; }
        }
        #endregion
    }
}
