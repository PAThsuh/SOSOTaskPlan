using SOSOTaskPlanning.DefineClasses;

namespace SOSOTaskPlanningMTest
{
    [TestClass]
    public class HolidaysTest
    {
        Holidays holidays = Holidays.CreateHolidays;

        public void AddHolidaysTest()
        {           

            holidays.AddHoliday(Convert.ToDateTime("23/Aug/2022"));
        }

        [TestMethod]
        public void IsHolidayTest()
        {
            Assert.AreEqual(true, holidays.IsHoliday(Convert.ToDateTime("23/Aug/2022")));
            
        }

        [TestMethod]
        public void IsNotHolidayTest()
        {
            Assert.AreEqual(false, holidays.IsHoliday(Convert.ToDateTime("21/Aug/2022")));

        }
    }
}