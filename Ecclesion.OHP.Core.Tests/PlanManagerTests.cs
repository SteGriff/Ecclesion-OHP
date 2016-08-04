using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ecclesion.OHP.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecclesion.OHP.Core.Models;

namespace Ecclesion.OHP.Core.Tests
{
    [TestClass()]
    public class PlanManagerTests
    {
        [TestMethod()]
        public void SaveOpenPlanTest()
        {
            //TODO Cleanup by deleting plan by name

            //Create a plan and save it
            // should have the same filename every time
            // due to hash/datetime

            var items = new List<Interfaces.IPlanItem>
            {
                new Song("Our God is Greater"),
                new Song("Guardian")
            };

            var created = DateTime.Parse("2016-08-01T09:00Z");

            var plan = new Plan()
            {
                Created = created,
                Items = items,
                ToBeUsed = created.AddDays(6)
            };

            PlanManager.CurrentPlan = plan;
            var result = PlanManager.SaveOpenPlan();

            //Test that it saved
            Assert.IsTrue(result.Result == Enums.ActionResultEnum.Completed);

            //Get the filename
            var filename = result.Data["file"];

            //Attempt to reopen the plan by name
            PlanManager.LoadPlan(filename);
            

        }
    }
}