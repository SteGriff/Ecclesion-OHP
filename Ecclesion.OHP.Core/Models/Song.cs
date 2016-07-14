using Ecclesion.OHP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecclesion.OHP.Core.Enums;
using System.Security.Cryptography;

namespace Ecclesion.OHP.Core.Models
{
    public class Song : IPlanItem
    {
        public string UID
        {
            get
            {
                return string.Format("Song-{0}-{1}", FirstLine, Hash);
            }
        }

        public string Hash
        {
            get
            {
                //Hash the title and lyrics together (treated as UTF8)
                return (Title + Environment.NewLine + Lyrics).GetMD5();
            }
        }

        public PlanItemType ItemType { get; set; }

        public string Title { get; set; }

        public string FirstLine
        {
            get
            {
                var ixFirstNewLine = Lyrics.IndexOf(Environment.NewLine);
                if (ixFirstNewLine > -1)
                {
                    return Lyrics.Substring(0, ixFirstNewLine);
                }

                //No newline, return whole lyrics
                return Lyrics;
            }
        }

        public string Lyrics { get; set; }

        public string Content { get { return Lyrics; } }

        public int Order { get; set; }

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
