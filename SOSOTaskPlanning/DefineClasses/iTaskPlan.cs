namespace SOSOTaskPlanning.DefineClasses
{
    public interface iTaskPlan
    {
        public DateTime GetTaskEndDate(DateTime startDate, double numOfTaskDay);
    }
}
