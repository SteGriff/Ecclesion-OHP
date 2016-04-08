using Ecclesion.OHP.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core.Interfaces
{
    public interface IPlanItem
    {
        string Name { get; set; }
        PlanItemType ItemType { get; set; }

    }
}
