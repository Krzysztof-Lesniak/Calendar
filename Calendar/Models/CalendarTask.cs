using Calendar.Database;

namespace Calendar.Models
{
    public class CalendarTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int CalendarID { get; set; }

        public CalendarTask(int id, string title, DateTime date, int CalendarID)
        {
            Id = id;
            Title = title;
            Date = date;
            this.CalendarID = CalendarID;
        }
        
    }
}