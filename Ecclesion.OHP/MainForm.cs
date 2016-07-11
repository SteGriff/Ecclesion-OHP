using Ecclesion.OHP.Classes;
using Ecclesion.OHP.Core;
using Ecclesion.OHP.Core.Interfaces;
using Ecclesion.OHP.Core.Models;
using Ecclesion.OHP.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private DisplayController _displayController;
        private DisplayController DisplayController
        {
            get
            {
                if (_displayController == null)
                {
                    _displayController = new DisplayController(_plan);
                }
                return _displayController;
            }
        }

        private DisplayScreen _displayForm;
        private DisplayScreen DisplayForm
        {
            get
            {
                if (_displayForm == null)
                {
                    _displayForm = new DisplayScreen(DisplayController);
                    _displayForm.FormClosed += DisplayForm_FormClosed;
                }
                return _displayForm;
            }
        }

        private bool _displayIsDisplaying;
        private bool DisplayIsDisplaying
        {
            get
            {
                return _displayIsDisplaying;
            }
            set
            {
                _displayIsDisplaying = value;
                UpdateDisplayChecks();
            }
        }

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

            //Get a reference to DisplayForm just to make sure it exists
            var wakeUp = DisplayForm.Enabled;
        }

        private void UpdateView()
        {
            planOutline.Text = _plan.ToString();

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
            //var oc = new ListBox.ObjectCollection(planItemsList, _plan.Items.ToArray());

            //TODO Optimize refresh of plan items
            foreach (var item in _plan.Items)
            {
                planItemsList.Items.Add(item);
            }
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
            if (((RadioButton)sender).Checked)
            {
                DisplayOn();
            }
        }

        private void displayOffSwitch_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                DisplayOff();
            }
        }

        private void DisplayOff()
        {
            if (DisplayIsDisplaying)
            {
                ScreenManager.SetFullscreen(DisplayForm, false);
                DisplayForm.Close();
                CleanUpDisplay();
            }
        }

        private void DisplayOn()
        {
            if (!DisplayIsDisplaying)
            {
                DisplayIsDisplaying = true;
                DisplayForm.Show();
                ScreenManager.SetFullscreen(DisplayForm, true);
            }
        }

        private void CleanUpDisplay()
        {
            DisplayIsDisplaying = false;
            _displayForm = null;
        }

        private void DisplayForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanUpDisplay();
        }

        private void planItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IPlanItem item = (IPlanItem)planItemsList.SelectedItem;
            DisplayController.DisplayingItem = item;
        }
    }
}

