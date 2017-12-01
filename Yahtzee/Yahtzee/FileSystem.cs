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
        public FileSystem() : this(Assembly.GetExecutingAssembly().GetName().Name) { }
        private FileSystem(string appName) : this(Application.StartupPath, appName) { }
        private FileSystem(string root, string appName)
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

        public bool AppFileExists(string filePath)
        {
            return File.Exists(AppDir + "\\" + filePath);
        }

        public bool ConfigFileExists(string filePath)
        {
            return File.Exists(ConfigDir + "\\" + filePath);
        }

        public bool WriteFile(string fileName, string contents)
        {
            try
            {
                File.WriteAllText(AppDir + "\\" + fileName, contents);

                return true;
            }
            catch { return false; }
        }

        public bool WriteFile(string directory, string fileName, string contents)
        {
            try
            {
                File.WriteAllText(AppDir + "\\" + directory + "\\" + fileName, contents);

                return true;
            }
            catch { return false; }
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

        public string ReadFile(string directoryName, string fileName)
        {
            return File.ReadAllText(RootDir + "\\" + directoryName + "\\" + fileName);
        }

        public string ReadConfigFile(string fileName)
        {
            return File.ReadAllText(ConfigDir + "\\" + fileName);
        }

        public bool DeleteFile(string directoryName, string fileName)
        {
            try
            {
                File.Delete(RootDir + "\\" + directoryName + "\\" + fileName);

                return true;
            }
            catch { return false; }
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
