using Ecclesion.OHP.Enums;
using Ecclesion.OHP.Core.Interfaces;
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
    public partial class ItemEditor : Form
    {
        private ItemEditorMode _mode;
        private IPlanItem _item;

        public ItemEditor()
        {
            InitializeComponent();
        }

        public ItemEditor(ItemEditorMode mode)
        {
            _mode = mode;
        }

        public IPlanItem Item
        {
            get
            {
                return _item;
            }
        }

        private void SaveItem()
        {
            

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            SaveItem();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
