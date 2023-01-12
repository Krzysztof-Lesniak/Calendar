using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calendar.Models;

namespace Calendar.Database
{
    internal static class CalendarDb
    {
        public static List<User> Users { get; set; }
        public static List<CalendarTask> CalendarTasks { get; set; }
        private static int numberOfCalendar = 1;

        static CalendarDb()
        {
            CalendarTasks = new List<CalendarTask>();
        }
       
        public static void save()
        {
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + numberOfCalendar.ToString() + ".bin");
            

            numberOfCalendar++;
        }
    }
}
