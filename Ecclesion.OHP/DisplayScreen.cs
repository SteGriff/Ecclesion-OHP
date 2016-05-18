using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP
{
    public partial class DisplayScreen : Form
    {
        private Keys[] _quitKeys = new[] { Keys.Escape, Keys.Q };

        public DisplayScreen()
        {
            InitializeComponent();
        }

        private void DisplayScreen_Load(object sender, EventArgs e)
        {

        }

        private void DisplayScreen_KeyUp(object sender, KeyEventArgs e)
        {
            if (_quitKeys.Contains(e.KeyCode))
            {
                Close();
            }
        }
    }
}
