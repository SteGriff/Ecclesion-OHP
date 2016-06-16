namespace Ecclesion.OHP.Core.Models
{
    public class Slide
    {
        public string Shortcut { get; set; }
        public string Text { get; set; }
        public int Index { get; set; }

        public Slide()
        {
        }

        public Slide(string shortcut, string text, int order)
        {
            Shortcut = shortcut;
            Text = text;
            Index = order;
        }
    }
}
