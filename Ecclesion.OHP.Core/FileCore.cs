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
    public static class FileCore
    {
        private const string PLANS = "plans";
        private const string SONGS = "songs";
        private const string NOTICES = "notices";

        private const string CURRENT_PLAN = "currentPlan.txt";

        private static List<string> _directories = new List<string> { PLANS, SONGS, NOTICES };

        public static void RunChecks()
        {
            CheckSpecialDirectoriesExist();
        }

        private static void CheckSpecialDirectoriesExist()
        {
            foreach (var d in _directories)
            {
                if (!Directory.Exists(d))
                {
                    Directory.CreateDirectory(d);
                }
            }
        }

        public static string CurrentPlanCode
        {
            get
            {
                var currentPlanFilePath = Path.Combine(PLANS, CURRENT_PLAN);

                if (Directory.Exists(PLANS))
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
        }

        public static void SetCurrentPlan(string planCode)
        {
            var currentPlanFilePath = Path.Combine(PLANS, CURRENT_PLAN);

            if (Directory.Exists(PLANS))
            {
                File.WriteAllText(currentPlanFilePath, planCode);
            }
        }

        public static void SavePlan(Plan plan)
        {
            var planPath = Path.Combine(PLANS, plan.Code);

            if (Directory.Exists(PLANS))
            {
                var content = JsonConvert.SerializeObject(plan, Formatting.Indented);
                File.WriteAllText(planPath, content);
            }
        }

        public static Plan GetPlanByCode(string planCode)
        {
            var currentPlanFilePath = Path.Combine(PLANS, planCode);

            if (Directory.Exists(PLANS))
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
