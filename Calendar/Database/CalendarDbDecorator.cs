using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Calendar.Models;
using Newtonsoft.Json;

namespace Calendar.Database
{
    internal static class CalendarDbDecorator
    {
        public static List<User> Users => _calendarDb.Users;
        public static List<CalendarTask> CalendarTasks => _calendarDb.CalendarTasks;
        public static int calNr { get; set; }

        private static CalendarDb _calendarDb = new CalendarDb();
        public static List<int> CalendarIds { get; set; }
        static CalendarDbDecorator()
        {
            calNr= 0;
            CalendarIds= new List<int>();
        }
        
        public static void save()
        {
            calNr++;
            CalendarObj CalendarObject = new CalendarObj(calNr);
            CalendarObject.TaskList = CalendarTasks;
            CalendarIds.Add(calNr);
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calNr.ToString() + ".json");
            var z = JsonConvert.SerializeObject(_calendarDb);
            File.WriteAllText(fullPathOfFile, z);
        }
        
        public static void Load(int calendarNumber)
        {
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calendarNumber.ToString() + ".json");
            var tempStringLoad = File.ReadAllText(fullPathOfFile);
            _calendarDb = JsonConvert.DeserializeObject<CalendarDb>(tempStringLoad);
        }
        public static void Delete(int calendarNumber)
        {
            calNr--;
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calendarNumber.ToString() + ".json");
            File.Delete(fullPathOfFile);
        }
    }
}
