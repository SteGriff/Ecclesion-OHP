﻿using System;
using System.Linq;
using System.Windows.Forms;
using Ecclesion.OHP.Core;
using Ecclesion.OHP.Core.Interfaces;

namespace Ecclesion.OHP.Usercontrols
{
    public delegate void ItemSelectedHandler(object sender, EventArgs e);

    public partial class ItemSuggestionsFrame : UserControl
    {
        public event ItemSelectedHandler ItemSelected;

        public string Input { get; set; }
        public IPlanItem SelectedItem { get; set; }

        public ItemSuggestionsFrame()
        {
            InitializeComponent();
        }

        public void StartTimer()
        {
            suggestionTimer.Stop();
            suggestionTimer.Start();
        }

        private void PopulateSuggestions(string input)
        {
            Visible = true;

            suggestionTimer.Stop();

            if (!string.IsNullOrWhiteSpace(input))
            {
                //Remove all items
                itemSuggestions.Items.Clear();

                //Get matches and populate list box
                var matches = SongManager.FindMatches(input);
                if (matches.Any())
                {
                    itemSuggestions.Items.AddRange(matches.ToArray());
                    itemSuggestions.Visible = true;
                    addItButton.Visible = true;
                }

            }
        }
        
        private void suggestionTimer_Tick(object sender, EventArgs e)
        {
            PopulateSuggestions(Input);
        }
        
        private void addItButton_Click(object sender, EventArgs e)
        {
            AddIt();
        }

        private void itemSuggestions_DoubleClick(object sender, EventArgs e)
        {
            AddIt();
        }

        private void itemSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddIt();
            }
        }

        private void AddIt()
        {
            Visible = false;
            SelectedItem = SongManager.SelectedMatch(itemSuggestions.SelectedIndex);
            RaiseItemSelected();
        }

        private void RaiseItemSelected()
        {
            ItemSelected(this, new EventArgs());
        }

    }
}