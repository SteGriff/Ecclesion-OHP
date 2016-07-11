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
        private Keys[] _prevKeys = new[] { Keys.Left, Keys.Up, Keys.Back };

        private Slide _currentSlide;
        public Slide CurrentSlide
        {
            get
            {
                return _currentSlide;
            }
            set
            {
                _currentSlide = value;
                RaiseUpdate();
            }
        }

        public List<Slide> CurrentItemSlides { get; set; }

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
                SetNewDisplayingItem();
            }
        }

        public DisplayController(Plan plan)
        {
            _plan = plan;
            if (plan.Items.Any())
            {
                DisplayingItem = plan.Items.FirstOrDefault();
            }
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
            var nextSlide = CurrentItemSlides
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

        private void GoFirst()
        {
            CurrentSlide = CurrentItemSlides.FirstOrDefault();
        }

        private Slide GetSlideByShortcutKey(string shortcut)
        {
            return CurrentItemSlides.Where(s => s.Shortcut == shortcut).SingleOrDefault();
        }

        private void RaiseCloseDisplay()
        {
            CloseDisplay?.Invoke(this, new EventArgs());
        }

        private void RaiseUpdate()
        {
            Update?.Invoke(this, new EventArgs());
        }

        private void SetNewDisplayingItem()
        {
            //Generate slides for the displaying item
            var sf = new SlideFactory(DisplayingItem.Content, 32, 600, 400);
            CurrentItemSlides = sf.Slides;

            //Go to the first slide
            GoFirst();

            //Get clients to refresh
            RaiseUpdate();
        }
    }
}
