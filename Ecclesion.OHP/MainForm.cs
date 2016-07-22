using Ecclesion.OHP.Classes;
using Ecclesion.OHP.Core;
using Ecclesion.OHP.Core.Interfaces;
using Ecclesion.OHP.Core.Models;
using Ecclesion.OHP.Enums;
using Ecclesion.OHP.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP
{
    public partial class MainForm : Form
    {
        private ItemSuggestionsFrame itemSuggestionsFrame;

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

            FileCore.RunChecks();

            ScreenManager.Initialise();
            DisplayOff();

            UpdateView();

        }

        private void InitializeMyComponents()
        {
            _plan.PlanItemAdded += _plan_PlanItemAdded;

            SongManager.EagerLoad();

            //Get a reference to DisplayForm just to make sure it exists
            var wakeUp = DisplayForm.Enabled;

            var itemSuggestionsFrameParent = planDisplaySplitter.Panel2;
            itemSuggestionsFrame = new ItemSuggestionsFrame()
            {
                Parent = itemSuggestionsFrameParent,
                Width = itemSuggestionsFrameParent.Width,
                Height = 400,
                Location = new Point(0, planItemsLabel.Location.Y),
                Anchor = AnchorStyles.Left & AnchorStyles.Top & AnchorStyles.Right & AnchorStyles.Bottom,
                Visible = false
            };

            itemSuggestionsFrame.ItemSelected += ItemSuggestionsFrame_ItemSelected;
        }

        private void ItemSuggestionsFrame_ItemSelected(object sender, EventArgs e)
        {
            var frame = (ItemSuggestionsFrame)sender;
            _plan.AddItem(frame.SelectedItem);
        }

        private void _plan_PlanItemAdded(object sender, EventArgs e)
        {
            RefreshPlanItems();
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
                _plan.AddItem(editor.Item);
            }
            
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
            displayOnSwitch.Checked = false;
            projectionOnLight.Visible = false;
            ScreenManager.SetFullscreen(DisplayForm, false);
            DisplayForm.Close();
            CleanUpDisplay();
        }

        private void DisplayOn()
        {
            if (!DisplayIsDisplaying)
            {
                displayOffSwitch.Checked = false;
                projectionOnLight.Visible = true;
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

        private void newItemInput_TextChanged(object sender, EventArgs e)
        {
            var box = (PlaceholderTextbox)sender;
            if (box.HasUserContent)
            {
                if (box.Text.Length > 2)
                {
                    itemSuggestionsFrame.StartTimer();
                    itemSuggestionsFrame.Input = box.Text;
                }
                else
                {
                    itemSuggestionsFrame.GoAway();
                }
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            newItemInput.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPlan();
        }

        private void newPlanButton_Click_1(object sender, EventArgs e)
        {
            NewPlan();
        }

        private void NewPlan()
        {
            try
            {
                PlanManager.NewPlan();
            }
            catch (Exception ex)
            {
                MessageBox.Show("A new plan was created. However, there was a problem saving the existing plan: " + Environment.NewLine + ex.Message, "New Plan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void savePlanButton_Click(object sender, EventArgs e)
        {
            SavePlan();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SavePlan();
        }

        private void SavePlan()
        {
            try
            {
                PlanManager.SaveOpenPlan();
                MessageBox.Show("Plan saved", "Save Plan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("There was a problem saving this plan: " + Environment.NewLine + ex.Message, "Save Plan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void loadPlanButton_Click(object sender, EventArgs e)
        {
            OpenPlan();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPlan();
        }

        private void OpenPlan()
        {
            string filter = string.Format("Service plan files (*{0})|*{0}", PlanFileCore.FILE_EXT);
            var loadDialog = new OpenFileDialog()
            {
                Filter = filter,
                Title = "Open a service plan",
                Multiselect  = false,
                DefaultExt = PlanFileCore.FILE_EXT,
                ValidateNames = true,
                InitialDirectory = FileCore.GetPath(FileCore.PLANS)
            };

            var result = loadDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                PlanManager.LoadPlan(loadDialog.FileName);
            }
        }
    }
}

