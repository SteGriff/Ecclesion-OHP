using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP
{
    public partial class PlaceholderTextbox : TextBox
    {
        public string Placeholder { get; set; }

        public PlaceholderTextbox()
        {
            InitializeComponent();
            Placeholder = "";
            CommonSetup();
        }

        public PlaceholderTextbox(string placeholder)
        {
            InitializeComponent();
            Placeholder = placeholder;
            CommonSetup();
        }

        private void CommonSetup()
        {
            ForeColor = SystemColors.GrayText;
            Text = Placeholder;
            GotFocus += PlaceholderTextbox_GotFocus;
            LostFocus += PlaceholderTextbox_LostFocus;
        }

        private void PlaceholderTextbox_LostFocus(object sender, EventArgs e)
        {
            if (Text == string.Empty)
            {
                Text = Placeholder;
                ForeColor = SystemColors.GrayText;
            }
        }

        private void PlaceholderTextbox_GotFocus(object sender, EventArgs e)
        {
            if (Text == Placeholder)
            {
                Text = string.Empty;
                ForeColor = SystemColors.ControlText;
            }
        }
    }
}
