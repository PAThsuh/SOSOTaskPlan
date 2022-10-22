namespace SOSOTaskPlanning.DefineClasses
{
    public sealed class WeekEnds : iWeekEnds 
    {
        private static WeekEnds weekEnds = null;
        public static WeekEnds GetWeekEnds
        {
            get
            {
                if (weekEnds == null)
                    weekEnds = new WeekEnds();
                return weekEnds;
            }
        }
        public Boolean IsWeekEnd(DateTime weekEnd)
        {
            if (weekEnd.DayOfWeek == DayOfWeek.Saturday || weekEnd.DayOfWeek == DayOfWeek.Sunday)
                return true;

            return false;
        }
    }
}
