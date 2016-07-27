using Ecclesion.OHP.Core.Enums;
using Ecclesion.OHP.Core.Exceptions;
using Ecclesion.OHP.Core.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters;
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
            var result = SavePlan(plan);

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
                return new ActionResult(ActionResultEnum.Unnecessary);
            }

            var planPath = FileCore.GetPath(FileCore.PLANS, plan.Code + FILE_EXT);

            if (Directory.Exists(FileCore.PLANS))
            {
                var content = JsonConvert.SerializeObject(plan, Formatting.Indented, new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.Objects,
                    TypeNameAssemblyFormat = FormatterAssemblyStyle.Simple
                });
                File.WriteAllText(planPath, content);
            }
            else
            {
                throw new FileNotFoundException(
                    string.Format("The plans directory at '{0}' does not exist and has not been restored. Perhaps somebody messed with the internal files?", FileCore.PLANS)
                );
            }

            return new ActionResult(ActionResultEnum.Completed, "file", planPath);
        }

        private static bool WorthSaving(Plan plan)
        {
            return plan.Items.Count > 0 || plan.ToBeUsed.Year > 1;
        }

        public static Plan GetPlanByCode(string planCode)
        {
            var planFilePath = Path.Combine(FileCore.PLANS, planCode, FILE_EXT);
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
                        Plan thePlan = JsonConvert.DeserializeObject<Plan>(planContent, new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Objects });
                        return thePlan;
                    }
                    catch (Exception ex)
                    {
                        throw;
                        //Version mismatch or something?
                    }

                }
            }

            throw new FileNotFoundException(string.Format("The plan file '{0}' cannot be found", filename));
        }


    }
}
