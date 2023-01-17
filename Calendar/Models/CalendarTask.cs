using Calendar.Database;

namespace Calendar.Models
{
    public class CalendarTask
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public Guid CalendarID { get; set; }

        public CalendarTask(string title, DateTime date, Guid CalendarID)
        {
            Id = Guid.NewGuid();
            Title = title;
            Date = date;
            this.CalendarID = CalendarID;
        }
        public CalendarTask()
        {

        }
        
    }
}