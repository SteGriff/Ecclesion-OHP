using Ecclesion.OHP.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core.Models
{
    public class Plan
    {
        public string Code
        {
            get
            {
                return ToBeUsed.ToString("yyyy-mm-dd") + Items.GetHashCode().ToString();
            }
        }

        public DateTime Created { get; set; }
        public DateTime ToBeUsed { get; set; }
        public List<IPlanItem> Items { get; set; }

        public Plan()
        {
            Created = DateTime.Now;
            Items = new List<IPlanItem>();
        }

        public override int GetHashCode()
        {
            return ToBeUsed.GetHashCode() % Created.GetHashCode() % Items.GetHashCode();
        }

        public override string ToString()
        {
            if (ToBeUsed == DateTime.MinValue)
            {
                return "Unnamed Plan";
            }

            //Like "9:00 on 21 Apr 2016"
            return String.Format("{0} on {1}",
                ToBeUsed.ToString("h:mm"),
                ToBeUsed.ToString("dd MMM yyyy"));
        }
    }
}
