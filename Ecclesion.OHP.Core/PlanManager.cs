using Ecclesion.OHP.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core
{
    public static class PlanManager
    {
        private static Plan _currentPlan;
        public static Plan CurrentPlan
        {
            get
            {
                if (_currentPlan == null)
                {
                    //Try to load most recent plan
                    var currentPlanCode = FileCore.CurrentPlanCode;

                    if (currentPlanCode == null)
                    {
                        //No recent plan exists, create new
                        _currentPlan = new Plan();
                    }
                    else
                    {
                        _currentPlan = FileCore.GetPlanByCode(currentPlanCode);
                    }
                    
                }

                return _currentPlan;
            }
            set
            {
                FileCore.SetCurrentPlan(value);
                _currentPlan = value;
            }

        }

        public static void NewPlan()
        {
            SaveOpenPlan();

            var newPlan = new Plan();

            CurrentPlan = newPlan; 
        }

        public static void SaveOpenPlan()
        {
            FileCore.SavePlan(CurrentPlan);
        }
    }
}
