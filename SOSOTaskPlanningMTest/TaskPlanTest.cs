using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOSOTaskPlanning.DefineClasses;

namespace SOSOTaskPlanningMTest
{
    [TestClass]
    public class TaskPlanTest
    {

        [TestMethod]
        public void GetTaskEndDateTest()
        {
            Holidays holidays = Holidays.CreateHolidays;
            WeekEnds weekEnds = WeekEnds.GetWeekEnds;

            TaskPlan taskPlan = new TaskPlan(holidays,weekEnds);

            Assert.AreEqual(Convert.ToDateTime("26/Aug/2022"), taskPlan.GetTaskEndDate(Convert.ToDateTime("19/Aug/2022"), 5));

        }

    }
}
