namespace SOSOTaskPlanning.DefineClasses
{
    public sealed class Holidays : iHolidays
    {
        private List<DateTime> lstHolidays = new List<DateTime>();

        private static Holidays holidays = null;
        public static Holidays CreateHolidays
        {
            get
            {
                if (holidays == null)
                    holidays = new Holidays();
                return holidays;
            }
        }
        public void AddHoliday(DateTime holiday)
        {
            if(!this.IsHoliday(holiday))
                lstHolidays.Add(holiday.Date);
        }

        public void DeleteHoliday(DateTime holiday)
        {
            if(this.IsHoliday(holiday))
                lstHolidays.Remove(holiday.Date);
        }

        public List<DateTime> GetHoliday()
        {
            return lstHolidays;
        }

        public Boolean IsHoliday(DateTime holiday)
        {
            if (lstHolidays.Count(hl => hl.Date == holiday.Date) != 0)
                return true;

            return false;
        }
    }
}
