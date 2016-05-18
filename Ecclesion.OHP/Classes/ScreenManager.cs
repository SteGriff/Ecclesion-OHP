using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP.Classes
{
    public static class ScreenManager
    {
        public static List<Screen> AllScreens { get; set; }
        public static Screen MainScreen { get; set; }
        public static List<Screen> OtherScreens { get; set; }
        public static bool SingleScreenMode
        {
            get
            {
                return AllScreens.Count == 1;
            }
        }

        public static void Initialise()
        {
            AllScreens = Screen.AllScreens.ToList();
            OtherScreens = AllScreens.Where(s => !s.Primary).ToList();
            MainScreen = Screen.PrimaryScreen;

        }

        public static void SetFullscreen(Form aForm, bool fullscreen)
        {
            /*
                Thanks mammadalius
                http://stackoverflow.com/a/8868761
                Accessed 2015-05-18
            */

            if (fullscreen)
            {
                var targetScreen = SingleScreenMode
                    ? MainScreen
                    : OtherScreens.First();

                aForm.WindowState = FormWindowState.Normal;
                aForm.FormBorderStyle = FormBorderStyle.None;
                aForm.Bounds = targetScreen.Bounds;
            }
            else
            {
                aForm.WindowState = FormWindowState.Maximized;
                aForm.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

    }
}
