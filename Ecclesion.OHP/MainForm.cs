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

            PlanFileCore.RunChecks();

            UpdateView();

        }

        private void InitializeMyComponents()
        {
            newItemInput = new PlaceholderTextbox("Start typing a song name...");
        }

        private void UpdateView()
        {
            planOutline.Text = _plan.ToString();
            //planItemsList.DataSource = _plan.Items;
        }

        private void RefreshPlanItems()
        {
            planItemsList.Items.Clear();
            var oc = new ListBox.ObjectCollection(planItemsList, _plan.Items.ToArray());
            //planItemsList.Items.AddRange(oc);
            
        }
        
        private void newItemButton_Click(object sender, EventArgs e)
        {
            var editor = new ItemEditor(ItemEditorMode.Create);
            editor.ShowDialog();

            if (editor.DialogResult == DialogResult.OK)
            {
                _plan.Items.Add(editor.Item);
            }

            RefreshPlanItems();

        }



        private void newPlanButton_Click(object sender, EventArgs e)
        {
            PlanManager.NewPlan();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void displayOnSwitch_CheckedChanged(object sender, EventArgs e)
        {
            var displayForm = new DisplayScreen();
            var screens = Screen.AllScreens;
            
            
        }
    }
}
