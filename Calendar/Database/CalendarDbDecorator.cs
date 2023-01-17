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
        public static List<CalendarObj> CalendarObjects => _calendarDb.CalendarObjects;
        public static int calNr { get; set; } = 0;
        public static int taskNr { get; set; } = 0;

        private static CalendarDb _calendarDb = new CalendarDb();
        public static List<int> CalendarIds => _calendarDb.CalendarIds;
        


        public static void save(int nrOfCalendar) //invoked when calendar is loaded
        {
            CalendarObjects.Find(x => x.Id == nrOfCalendar).TaskList.Clear();
            CalendarObjects.Find(x => x.Id == nrOfCalendar).TaskList = CalendarTasks;

            
            //string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            //string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + nrOfCalendar + ".json");
            //var z = JsonConvert.SerializeObject(_calendarDb);
            //File.WriteAllText(fullPathOfFile, z);
        }
        public static void save() //ivoked when calendar is new
        {
            calNr++;
            CalendarObj CalendarObject = new CalendarObj(calNr);
            CalendarObject.TaskList = CalendarTasks;
            CalendarObject.Id = calNr;
            // Add CalendarObject to CalendarObjects in the way that the elements will not be errased
            CalendarIds.Add(calNr);
            
            
            
        }

        public static void Load(int calendarNumber)
        {
            CalendarTasks.Clear();
            taskNr = 0;
            var loadedCalendar = CalendarObjects.Find(x => x.Id == calendarNumber);
            foreach (var task in loadedCalendar.TaskList)
            {
                CalendarTasks.Add(task);
            }


        }
        public static void Delete(int calendarNumber)
        {
            calNr--;
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calendarNumber.ToString() + ".json");
            File.Delete(fullPathOfFile);
        }
        public static void SaveEverything()
        {
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_db_.json");
            var z = JsonConvert.SerializeObject(_calendarDb);
            File.WriteAllText(fullPathOfFile, z);
        }

        public static void LoadEverything()
        {
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_db_.json");
            var tempStringLoad = File.ReadAllText(fullPathOfFile);
            _calendarDb = JsonConvert.DeserializeObject<CalendarDb>(tempStringLoad);
        }
    
    }
}
