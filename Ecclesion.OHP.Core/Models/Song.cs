using Ecclesion.OHP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecclesion.OHP.Core.Enums;

namespace Ecclesion.OHP.Core.Models
{
    public class Song : IPlanItem
    {
        public string UID
        {
            get
            {
                //TODO replace this with a proper DAL, Entity Framework or something
                return string.Format("Song-{0}-{1}", FirstLine, Title);
            }
        }

        public PlanItemType ItemType { get; set; }

        public string Title { get; set; }

        public string FirstLine
        {
            get
            {
                var ixFirstNewLine = Lyrics.IndexOf(Environment.NewLine);
                return Lyrics.Substring(0, ixFirstNewLine);
            }
        }

        public string Lyrics { get; set; }

        public string Content { get { return Lyrics; } }

        public Song()
        {
            CommonSetup();
        }

        public Song(string title)
        {
            CommonSetup();
            Title = title;
        }

        private void CommonSetup()
        {
            ItemType = PlanItemType.Song;

        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", FirstLine, Title);
        }
    }
}
