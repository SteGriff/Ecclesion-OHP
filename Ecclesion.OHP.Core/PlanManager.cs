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
                    var currentPlanCode = PlanFileCore.CurrentPlanCode;

                    if (currentPlanCode != null)
                    {
                        _currentPlan = PlanFileCore.GetPlanByCode(currentPlanCode);
                    }
                    
                }

                //If still null, i.e. referenced plan did not exist
                // return new plan
                if (_currentPlan == null)
                {
                    _currentPlan = new Plan();
                }

                return _currentPlan;
            }
            set
            {
                PlanFileCore.SetCurrentPlan(value);
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
            PlanFileCore.SavePlan(CurrentPlan);
        }
    }
}
