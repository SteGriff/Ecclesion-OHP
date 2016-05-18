using Ecclesion.OHP.Classes;
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

        private DisplayScreen _displayForm;
        private DisplayScreen DisplayForm
        {
            get
            {
                if (_displayForm == null)
                {
                    _displayForm = new DisplayScreen();
                    _displayForm.FormClosed += DisplayForm_FormClosed;
                }
                return _displayForm;
            }
        }

        private bool DisplayIsDisplaying { get; set; }

        public MainForm()
        {
            InitializeComponent();
            InitializeMyComponents();

            PlanFileCore.RunChecks();

            ScreenManager.Initialise();
            DisplayOff();

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

            UpdateDisplayChecks();
        }

        private void UpdateDisplayChecks()
        {
            displayOnSwitch.Checked = DisplayIsDisplaying;
            displayOffSwitch.Checked = !DisplayIsDisplaying;
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
            DisplayOn();
        }

        private void displayOffSwitch_CheckedChanged(object sender, EventArgs e)
        {
            DisplayOff();
        }

        private void DisplayOff()
        {
            if (DisplayIsDisplaying)
            {
                ScreenManager.SetFullscreen(DisplayForm, false);
                DisplayForm.Close();
            }            
        }

        private void DisplayOn()
        {
            if (!DisplayIsDisplaying)
            {
                DisplayForm.Show();
                DisplayIsDisplaying = true;
                ScreenManager.SetFullscreen(DisplayForm, true);
            }
        }

        private void DisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisplayIsDisplaying = false;
            UpdateDisplayChecks();
        }
    }
}
