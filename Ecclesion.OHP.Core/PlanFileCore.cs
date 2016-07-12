using Ecclesion.OHP.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecclesion.OHP.Core
{
    public static class PlanFileCore
    {
        private const string CURRENT_PLAN = "currentPlan.txt";

        public static string CurrentPlanCode
        {
            get
            {
                var currentPlanFilePath = Path.Combine(FileCore.PLANS, CURRENT_PLAN);

                if (Directory.Exists(FileCore.PLANS))
                {
                    if (File.Exists(currentPlanFilePath))
                    {
                        var content = File.ReadAllText(currentPlanFilePath);
                        return content;
                    }
                }

                return null;
            }
        }

        public static void SetCurrentPlan(Plan plan)
        {
            SetCurrentPlan(plan.Code);
            SavePlan(plan);
        }

        public static void SetCurrentPlan(string planCode)
        {
            var currentPlanFilePath = FileCore.GetPath(FileCore.PLANS, CURRENT_PLAN);

            if (Directory.Exists(FileCore.PLANS))
            {
                File.WriteAllText(currentPlanFilePath, planCode);
            }
        }

        public static void SavePlan(Plan plan)
        {
            if (!WorthSaving(plan))
            {
                return;
            }

            var planPath = FileCore.GetPath(FileCore.PLANS, plan.Code + ".txt");

            if (Directory.Exists(FileCore.PLANS))
            {
                var content = JsonConvert.SerializeObject(plan, Formatting.Indented);
                File.WriteAllText(planPath, content);
            }
        }

        private static bool WorthSaving(Plan plan)
        {
            return plan.Items.Count > 0 || plan.ToBeUsed.Year > 1;
        }

        public static Plan GetPlanByCode(string planCode)
        {
            var currentPlanFilePath = Path.Combine(FileCore.PLANS, planCode);

            if (Directory.Exists(FileCore.PLANS))
            {
                if (File.Exists(currentPlanFilePath))
                {
                    var planContent = File.ReadAllText(currentPlanFilePath);

                    try
                    {
                        Plan thePlan = JsonConvert.DeserializeObject<Plan>(planContent);
                        return thePlan;
                    }
                    catch (Exception)
                    {
                        //Version mismatch or something?
                    }
                    
                }
            }

            return null;
        }


    }
}
