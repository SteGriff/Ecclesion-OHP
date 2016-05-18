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
using Ecclesion.OHP.Core.Models;

namespace Ecclesion.OHP
{
    public partial class ItemEditor : Form
    {
        private ItemEditorMode _mode;
        private IPlanItem _item;

        private Dictionary<string, ItemEditorPage> TabsLookup;

        private ItemEditorPage Page
        {
            get
            {
                return TabsLookup
                    .Where(t => t.Key == itemEditorTabs.SelectedTab.Text)
                    .SingleOrDefault()
                    .Value;
            }
        }

        public ItemEditor()
        {
            InitializeComponent();
            _mode = ItemEditorMode.Create;
            CommonSetup();
        }

        public ItemEditor(ItemEditorMode mode)
        {
            InitializeComponent();
            _mode = mode;
            CommonSetup();
        }

        private void CommonSetup()
        {
            TabsLookup = new Dictionary<string, ItemEditorPage>
            {
                { "Song", ItemEditorPage.Song },
                { "Notices", ItemEditorPage.Notices }
            };

            SetupForMode();
        }

        private void SetupForMode()
        {
            if (_mode == ItemEditorMode.Create)
            {
                Text = "Create item";
                okButton.Text = "Create and add to plan";
            }
            else
            {
                Text = "Edit item";
                okButton.Text = "Save changes";
            }
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
            if (Page == ItemEditorPage.Song)
            {
                var song = new Song();
                song.Lyrics = lyricsText.Text;
                song.Title = titleText.Text;

                _item = song;
            }
            else
            {
                //TODO Create/Edit Notices

            }

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

        private void itemEditorTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TODO Warn user about losing data on other tab
        }
    }
}
