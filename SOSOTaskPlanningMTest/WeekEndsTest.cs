using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SOSOTaskPlanning.DefineClasses;

namespace SOSOTaskPlanningMTest
{
    [TestClass]
    public class WeekEndsTest
    {
        WeekEnds weekEnds  = WeekEnds.GetWeekEnds;

        [TestMethod]
        public void IsWeekEndsTest()
        {
            Assert.AreEqual(true, weekEnds.IsWeekEnd(Convert.ToDateTime("20/Aug/2022")));
        }

        [TestMethod]
        public void IsNotWeekEndsTest()
        {
            Assert.AreEqual(false, weekEnds.IsWeekEnd(Convert.ToDateTime("23/Aug/2022")));
        }
    }
}
