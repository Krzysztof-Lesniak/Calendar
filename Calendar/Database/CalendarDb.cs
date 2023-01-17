using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Database
{
    internal class CalendarDb
    {
        public List<User> Users { get; set; } = new List<User>();
        public List<CalendarTask> CalendarTasks { get; set; } = new List<CalendarTask>();
        //public List<CalendarObj> Calendars { get; set; } = new List<CalendarObj> ();
        public List<int> CalendarIds { get; set; } = new List<int>();
        public List<CalendarObj> CalendarObjects { get; set; } = new List<CalendarObj>();

        public CalendarDb()
        {

        }

        public void SaveEverything()
        {
            
        }

       
    }
}
