using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP.Usercontrols
{
    public partial class StyleEditor : UserControl
    {
        private Font _currentFont;
        public Font CurrentFont
        {
            get
            {
                return _currentFont;
            }
            set
            {
                _currentFont = value;
                RefreshView();
            }
        }

        public StyleEditor()
        {
            InitializeComponent();
        }

        private void RefreshView()
        {
            fontInfoLabel.Text = string.Format("{0}, {1}, {2}",
                CurrentFont.FontFamily.Name,
                CurrentFont.Style.ToString(),
                CurrentFont.SizeInPoints.ToString());
        }

        private void editFontButton_Click(object sender, EventArgs e)
        {
            var fontEditor = new FontDialog()
            {
                Font = CurrentFont,
            };

            fontEditor.ShowDialog();
        }
    }
}
