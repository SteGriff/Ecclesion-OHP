using Ecclesion.OHP.Core.Interfaces;
using Ecclesion.OHP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ecclesion.OHP.Core
{
    public delegate void CloseDisplayHandler(object sender, EventArgs e);
    public delegate void UpdateHandler(object sender, EventArgs e);

    public class DisplayController
    {
        public event CloseDisplayHandler CloseDisplay;
        public event UpdateHandler Update;

        private Plan _plan;
        private Keys[] _quitKeys = new[] { Keys.Escape, Keys.Q };
        private Keys[] _nextKeys = new[] { Keys.Right, Keys.Down, Keys.Enter, Keys.Space };
        private Keys[] _prevKeys = new[] { Keys.Left, Keys.Up, Keys.Back};

        public Slide CurrentSlide { get; set; }
        public List<Slide> Slides { get; set; }

        private IPlanItem _displayingItem;
        public IPlanItem DisplayingItem
        {
            get
            {
                return _displayingItem;
            }
            set
            {
                _displayingItem = value;
                RaiseUpdate();
            }
        }

        public DisplayController (Plan plan)
        {
            _plan = plan;
            DisplayingItem = plan.Items.FirstOrDefault();
        }

        public void KeyUp(object sender, KeyEventArgs e)
        {
            if (_quitKeys.Contains(e.KeyCode))
            {
                RaiseCloseDisplay();
            }
            else if (_nextKeys.Contains(e.KeyCode))
            {
                GoNext();
            }
            else if (_prevKeys.Contains(e.KeyCode))
            {
                GoPrevious();
            }
            else
            {
                // TODO Check for shortcut key
                var nextSlide = GetSlideByShortcutKey(e.KeyCode.ToString());
                if (nextSlide != null)
                {
                    CurrentSlide = nextSlide;
                }

            }
        }

        private void GetSlideByOffset(int offset)
        {
            var nextSlide = Slides
                .Where(s => s.Index == CurrentSlide.Index + offset)
                .FirstOrDefault();

            if (nextSlide != null)
            {
                CurrentSlide = nextSlide;
            }

            CurrentSlide = nextSlide;

        }

        private void GoNext()
        {
            GetSlideByOffset(1);
        }

        private void GoPrevious()
        {
            GetSlideByOffset(-1);
        }

        private Slide GetSlideByShortcutKey(string shortcut)
        {
            return Slides.Where(s => s.Shortcut == shortcut).SingleOrDefault();
        }

        private void RaiseCloseDisplay()
        {
            CloseDisplay(this, new EventArgs());
        }

        private void RaiseUpdate()
        {
            //Slides = DisplayingItem.Content

            Update(this, new EventArgs());
        }
    }
}
