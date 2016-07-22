using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core
{
    public static class FileCore
    {
        public const string PLANS = "plans";
        public const string SONGS = "songs";
        public const string NOTICES = "notices";

        private static List<string> _directories = new List<string> { PLANS, SONGS, NOTICES };

        public static void RunChecks()
        {
            CheckSpecialDirectoriesExist();
        }

        private static void CheckSpecialDirectoriesExist()
        {
            foreach (var d in _directories)
            {
                if (!Directory.Exists(d))
                {
                    Directory.CreateDirectory(d);
                }
            }
        }

        public static string GetPath(string type)
        {
            var myLocation = Environment.CurrentDirectory;
            return Path.Combine(myLocation, type);
        }

        public static string GetPath(string type, string file)
        {
            var myLocation = Environment.CurrentDirectory;
            return Path.Combine(myLocation, type, file);
        }

    }
}
