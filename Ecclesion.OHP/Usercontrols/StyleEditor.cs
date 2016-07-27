using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ecclesion.OHP.Usercontrols
{
    public delegate void UpdateStyleHandler(object sender, EventArgs e);

    public partial class StyleEditor : UserControl
    {
        public event UpdateStyleHandler UpdateStyle;

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
                if (value != null)
                {
                    RefreshView();
                    RaiseUpdateStyle();
                }
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

            var dialogResult = fontEditor.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                CurrentFont = fontEditor.Font;
            }
        }

        private void RaiseUpdateStyle()
        {
            UpdateStyle?.Invoke(this, new EventArgs());
        }
    }
}
