﻿using Ecclesion.OHP.Core;
using Ecclesion.OHP.Core.Models;
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

            FileCore.RunChecks();

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            planOutline.Text = _plan.ToString();
            planItemsList.DataSource = _plan.Items;
        }

        private void newItemButton_Click(object sender, EventArgs e)
        {
            var editor = new ItemEditor();
            editor.Show();
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
