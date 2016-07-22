using Ecclesion.OHP.Core.Enums;
using Ecclesion.OHP.Core.Exceptions;
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
        public const string FILE_EXT = ".plan";

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
            else
            {
                throw new FileNotFoundException(string.Format("Cannot set the current plan to '{0}' because the file '{1}' cannot be found", planCode, currentPlanFilePath));
            }
        }

        public static ActionResult SavePlan(Plan plan)
        {
            if (!WorthSaving(plan))
            {
                return ActionResult.Unnecessary;
            }

            var planPath = FileCore.GetPath(FileCore.PLANS, plan.Code + FILE_EXT);

            if (Directory.Exists(FileCore.PLANS))
            {
                var content = JsonConvert.SerializeObject(plan, Formatting.Indented);
                File.WriteAllText(planPath, content);
            }
            else
            {
                throw new FileNotFoundException(
                    string.Format("The plans directory at '{0}' does not exist and has not been restored. Perhaps somebody messed with the internal files?", FileCore.PLANS)
                );
            }

            return ActionResult.Completed;
        }

        private static bool WorthSaving(Plan plan)
        {
            return plan.Items.Count > 0 || plan.ToBeUsed.Year > 1;
        }

        public static Plan GetPlanByCode(string planCode)
        {
            var planFilePath = Path.Combine(FileCore.PLANS, planCode);
            return GetPlanByFilename(planFilePath);
        }

        public static Plan GetPlanByFilename(string filename)
        {
            if (Directory.Exists(FileCore.PLANS))
            {
                if (File.Exists(filename))
                {
                    var planContent = File.ReadAllText(filename);

                    try
                    {
                        Plan thePlan = JsonConvert.DeserializeObject<Plan>(planContent);
                        return thePlan;
                    }
                    catch (Exception ex)
                    {
                        //Error because
                        //Json deserialize an interface
                        throw;
                        //Version mismatch or something?
                    }

                }
            }

            throw new FileNotFoundException(string.Format("The plan file '{0}' cannot be found", filename));
        }


    }
}
