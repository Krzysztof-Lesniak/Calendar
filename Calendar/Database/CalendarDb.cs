using Calendar.Models;
using Newtonsoft.Json;
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
        public List<int> CalendarIds { get; set; } = new List<int>();
        public List<CalendarObj> CalendarObjects { get; set; } = new List<CalendarObj>();

        public CalendarDb()
        {

        }

        


    }
}
