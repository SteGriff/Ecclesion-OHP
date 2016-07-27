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
                        try
                        {
                            _currentPlan = PlanFileCore.GetPlanByCode(currentPlanCode);
                        }
                        catch (Exception)
                        {
                            //If referenced plan did not exist
                            // return new plan
                            _currentPlan = new Plan();
                        }
                    }

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
            //Save the current plan and then make a new one
            // if the save fails, still create a new plan
            // but alert the user
            // (behaviour to be confirmed)

            Exception exceptionFromSaving = null;

            try
            {
                SaveOpenPlan();
            }
            catch (Exception ex)
            {
                exceptionFromSaving = ex;
            }

            var newPlan = new Plan();
            CurrentPlan = newPlan;

            if (exceptionFromSaving != null)
            {
                throw exceptionFromSaving;
            }
        }

        public static ActionResult SaveOpenPlan()
        {
            return PlanFileCore.SavePlan(CurrentPlan);
        }

        public static void LoadPlan(string filename)
        {
            CurrentPlan = PlanFileCore.GetPlanByFilename(filename);
        }
    }
}
