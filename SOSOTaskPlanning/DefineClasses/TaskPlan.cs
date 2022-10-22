namespace SOSOTaskPlanning.DefineClasses
{
    public class TaskPlan : iTaskPlan
    {
        private Holidays holidays;
        private WeekEnds weekEnds;
        public TaskPlan(Holidays holidays, WeekEnds weekEnds)
        {
            this.holidays = holidays;
            this.weekEnds = weekEnds;
        }

        public DateTime GetTaskEndDate(DateTime startDate, double numOfTaskDay)
        {
            DateTime endDate = startDate;

            for (int numDay = 0; numDay < numOfTaskDay; numDay++)
            {
                endDate = startDate.AddDays(numDay);

                if (weekEnds.IsWeekEnd(endDate))
                {
                    numOfTaskDay += 1;
                }

                if (holidays.IsHoliday(endDate))
                    numOfTaskDay += 1;
            }

            return endDate;
        }
    }
}
