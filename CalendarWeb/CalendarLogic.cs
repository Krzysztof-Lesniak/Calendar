using Calendar.Database;
using Calendar.Models;

namespace Calendar
{
    public class CalendarLogic
    {
        private readonly DateTime now;
        public int month { get; set; }
        public int year { get; set; } 
        public int daysInMonth { get; set; } 
        public CalendarObj currentCalendar { get; set; } = new CalendarObj();
        public CalendarLogic()
        {
            now = DateTime.Now;
            month = now.Month;
            year = now.Year;
            daysInMonth = DateTime.DaysInMonth(year, month);
        }

        public  int GetNumberOfStartingDayOfTheWeek()
        {
            var startOfTheMonth = new DateTime(year, month, 1);
            var dayName = startOfTheMonth.DayOfWeek;
            int dayOfTheWeek = Convert.ToInt32(dayName);
            return dayOfTheWeek;
        }

        public  void NextMonthChange()
        {
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
        }
        public  void PrevMonthChange() 
        { 
            month--;
            if (month == 0)
            {
                month = 1;
                year--;
            }
        
        }
        public  void AddTask(string selectedDay, string textOfTask)
        {
            var dateString = Convert.ToString(selectedDay) 
                + '/' + Convert.ToString(month) 
                + '/' + Convert.ToString(year);
            var newCalendarTask = new CalendarTask(textOfTask, DateTime.Parse(dateString), currentCalendar.Id);
            //CalendarDbDecorator.AddTask(newCalendarTask);
            currentCalendar.TaskList.Add(newCalendarTask);
        }

    }
}
