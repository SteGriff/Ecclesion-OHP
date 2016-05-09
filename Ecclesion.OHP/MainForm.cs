using Ecclesion.OHP.Core;
using Ecclesion.OHP.Core.Models;
using Ecclesion.OHP.Enums;
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
    public partial class MainForm : Form
    {
        private Plan _plan
        {
            get
            {
                return PlanManager.CurrentPlan;
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeMyComponents();

            FileCore.RunChecks();

            UpdateDisplay();
        }

        private void InitializeMyComponents()
        {
            newItemInput = new PlaceholderTextbox("Start typing a song name...");
        }

        private void UpdateDisplay()
        {
            planOutline.Text = _plan.ToString();
            planItemsList.DataSource = _plan.Items;
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            var editor = new ItemEditor(ItemEditorMode.Create);
            editor.Show();

            if (editor.DialogResult == DialogResult.OK)
            {
                _plan.Items.Add(editor.Item);
            }
            
        }

        private void newPlanButton_Click(object sender, EventArgs e)
        {
            PlanManager.NewPlan();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
