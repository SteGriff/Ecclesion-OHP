using Ecclesion.OHP.Core.Enums;
using System.Collections.Generic;

namespace Ecclesion.OHP.Core
{
    public class ActionResult
    {
        public ActionResultEnum Result { get; set; }
        public Dictionary<string, string> Data { get; set; }

        public ActionResult(ActionResultEnum result)
        {
            Result = result;
        }

        public ActionResult(ActionResultEnum result, string key, string value)
        {
            Result = result;
            Data.Add(key, value);
        }
    }
}
