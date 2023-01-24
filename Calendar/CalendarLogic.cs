using Calendar.Database;
using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class CalendarLogic
    {
        private static DateTime now  = DateTime.Now;
        public static int month { get; set; } = now.Month;
        public static int year { get; set; } = now.Year;
        public static int daysInMonth { get; set; } = DateTime.DaysInMonth(year, month);
        public static CalendarObj currentCalendar { get; set; } = new CalendarObj();
        public CalendarLogic()
        {
        }

        public static int GetNumberOfStartingDayOfTheWeek()
        {
            var startOfTheMonth = new DateTime(year, month, 1);
            var dayName = startOfTheMonth.DayOfWeek;
            int dayOfTheWeek = Convert.ToInt32(dayName);
            return dayOfTheWeek;
        }

        public static void NextMonthChange()
        {
            month++;
            if (month == 13)
            {
                month = 1;
                year++;
            }
        }
        public static void PrevMonthChange() 
        { 
            month--;
            if (month == 0)
            {
                month = 1;
                year--;
            }
        
        }
        public static void AddTask(string selectedDay, string textOfTask)
        {
            var dateString = Convert.ToString(selectedDay) 
                + '/' + Convert.ToString(month) 
                + '/' + Convert.ToString(year);
            var newCalendarTask = new CalendarTask(textOfTask, DateTime.Parse(dateString), currentCalendar.Id);
            CalendarDbDecorator.AddTask(newCalendarTask);
            currentCalendar.TaskList.Add(newCalendarTask);
        }

    }
}
