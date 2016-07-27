using System;
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
                    Visible = true;
                }

            }
        }
        
        private void suggestionTimer_Tick(object sender, EventArgs e)
        {
            PopulateSuggestions(Input);
        }
        
        private void addItButton_Click(object sender, EventArgs e)
        {
            AddCurrentSelection();
        }

        private void itemSuggestions_DoubleClick(object sender, EventArgs e)
        {
            AddCurrentSelection();
        }

        private void itemSuggestions_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                AddCurrentSelection();
            }
        }

        public void AddCurrentSelection()
        {
            Visible = false;
            SelectedItem = SongManager.SelectedMatch(itemSuggestions.SelectedIndex);
            RaiseItemSelected();
        }

        private void RaiseItemSelected()
        {
            ItemSelected(this, new EventArgs());
        }

        public void GoAway()
        {
            Visible = false;
        }

        public void ChangeSelectedIndex(int offset)
        {
            if (itemSuggestions.SelectedIndex + offset < itemSuggestions.Items.Count
                && itemSuggestions.SelectedIndex + offset >= 0)
            { 
                itemSuggestions.SelectedIndex += offset;
            }
        }

    }
}
