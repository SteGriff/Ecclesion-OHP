using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ecclesion.OHP.Core;

namespace Ecclesion.OHP.Usercontrols
{
    public partial class SlideSelector : UserControl
    {
        private DisplayController _displayController;

        public SlideSelector(DisplayController displayController)
        {
            InitializeComponent();

            _displayController = displayController;
        }
    }
}
