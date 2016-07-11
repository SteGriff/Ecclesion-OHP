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
        string UID { get; }
        string Title { get; }
        PlanItemType ItemType { get; set; }
        int Order { get; set; }

        string Content { get; }
    }
}
