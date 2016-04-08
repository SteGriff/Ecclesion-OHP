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
        public string Name { get; set; }
        public PlanItemType ItemType { get; set; }

        
    }
}
