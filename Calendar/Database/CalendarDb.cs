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

        static CalendarDb()
        {
            CalendarTasks = new List<CalendarTask>();
        }
    }
}
