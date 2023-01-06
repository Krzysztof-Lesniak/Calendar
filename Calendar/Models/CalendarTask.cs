namespace Calendar.Models
{
    public class CalendarTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public CalendarTask(int id, string title, DateTime date)
        {
            Id = id;
            Title = title;
            Date = date;
        }
        
    }
}