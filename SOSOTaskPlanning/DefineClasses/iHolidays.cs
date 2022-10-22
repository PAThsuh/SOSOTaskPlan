namespace SOSOTaskPlanning.DefineClasses
{
    public interface iHolidays
    {
        public void AddHoliday(DateTime holiday);
        public void DeleteHoliday(DateTime holiday);
        public List<DateTime> GetHoliday();
        public Boolean IsHoliday(DateTime holiday);
    }
}
