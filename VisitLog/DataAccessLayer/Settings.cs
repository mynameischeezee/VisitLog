using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace VisitLog.DataAccessLayer
{
    public static class Settings
    {
        private static string _MainFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\VisitLog";
        private static string _SettingsFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\VisitLog\Log\Settings";
        private static string _VisitLogListFolder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\VisitLog\Log\VisitLogList";
        public static string MainFolder
        {
            get { return _MainFolder; }
            private set { MainFolder = value; }
        }

        public static string SettingsFolder
        {
            get { return _SettingsFolder; }
            private set { SettingsFolder = value; }
        }
        public static string VisitLogListFolder
        {
            get { return _VisitLogListFolder; }
            private set { VisitLogListFolder = value; }
        }
        private static void CreateMainFolder()
        {
            if (!Directory.Exists(_MainFolder))
            {
                Directory.CreateDirectory(_MainFolder);
            }
        }
        private static void CreateSettingsFolder()
        {
            if (!Directory.Exists(_SettingsFolder))
            {
                Directory.CreateDirectory(_SettingsFolder);
            }
        }
        private static void CreateVisitLogFolder()
        {
            if (!Directory.Exists(_VisitLogListFolder))
            {
                Directory.CreateDirectory(_VisitLogListFolder);
            }
        }
        private static void CreateSettingsFile()
        {
            if (!File.Exists(_SettingsFolder + @"\" + "Settings" + ".json "))
            {
                FileStream FileCreate = File.Create(_SettingsFolder + @"\" + "Settings" + ".json");
                FileCreate.Close();
                File.WriteAllText(_SettingsFolder + @"\" + "Settings" + ".json", "{\"ID\":0}");
            }
        }
        private static void CreateVisitsFile()
        {
            if (!File.Exists(_VisitLogListFolder + @"\" + "Visits" + ".json "))
            {
                FileStream FileCreate = File.Create(_VisitLogListFolder + @"\" + "Visits" + ".json");
                FileCreate.Close();
            }
        }
        public static void FolderInitialization()
        {
            CreateMainFolder();
            CreateSettingsFolder();
            CreateVisitLogFolder();
            CreateSettingsFile();
            CreateVisitsFile();
        }
    }
}
