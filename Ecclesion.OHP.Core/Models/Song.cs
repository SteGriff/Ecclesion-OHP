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
                var md5er = MD5.Create();

                //Add the title and lyrics together (treated as UTF8)
                
                var byteContent = Encoding.UTF8.GetBytes(Title + Environment.NewLine + Lyrics);
                var sb = new StringBuilder();
                foreach(var b in byteContent)
                {
                    sb.Append(b.ToString("x2").ToLower());
                }
                return sb.ToString();

                //Hash them with MD5 and return the hash as an ASCII string
                //return Encoding.UTF8.GetString(md5er.ComputeHash(byteContent));
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
