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
        public static int taskNr { get; set; } = 0;

        private static CalendarDb _calendarDb = new CalendarDb();
        
        public static void save(CalendarObj calendarToSave) //ivoked when calendar is new
        {

            CalendarObjects.Add(calendarToSave);
            // Add CalendarObject to CalendarObjects in the way that the elements will not be errased
            SaveEverything();  
            
        }

        public static CalendarObj Load(Guid calendarId)
        {
            CalendarTasks.Clear();
            CalendarObjects.Clear();
            LoadEverything();
            var loadedCalendar = CalendarObjects.Find(x => x.Id == calendarId);
            return loadedCalendar;


        }
        public static void Delete(int calendarNumber)
        {
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_db_.json");
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
