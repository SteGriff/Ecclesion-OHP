using Ecclesion.OHP.Core;
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
        private DisplayController _displayController;

        public DisplayScreen(DisplayController displayController)
        {
            InitializeComponent();
            _displayController = displayController;

            //Send key presses to the DisplayController
            KeyUp += new KeyEventHandler(_displayController.KeyUp);

            //Handle events from the DisplayController
            _displayController.CloseDisplay += DisplayController_CloseDisplay;
            _displayController.Update += DisplayController_Update;

            //Get correct first slide
            _displayController.RaiseUpdate();
        }

        private void DisplayController_Update(object sender, EventArgs e)
        {
            displayLabel.Text = _displayController.CurrentSlide.Text;
        }

        private void DisplayController_CloseDisplay(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
