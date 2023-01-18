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
        private static CalendarDb _calendarDb = new CalendarDb();//todo delete po przepisaniu wszystkich odwołań na dbcontext
        private static CalendarDbContext _dbContext;

        static CalendarDbDecorator()
        {
            _dbContext = new CalendarDbContext();
        }

        public static CalendarObj FindCalendarObj(Guid id)
        {
            return _dbContext.CalendarObjects.FirstOrDefault(x => x.Id == id);
        }

        public static void AddUser(string username,string password, role role)
        {
            _dbContext.Users.Add(new User(username,password,role));
            _dbContext.SaveChanges();
        }

        public static bool IfUserExists(string userName)
        {
           return _dbContext.Users.Any(x => x.UserName == userName);
        }

        public static User FindUser(string userName)
        {
            return _dbContext.Users.FirstOrDefault(x => x.UserName == userName);
        }

        public static void save(CalendarObj calendarToSave) //ivoked when calendar is new
        {
            _dbContext.CalendarObjects.Add(calendarToSave);
            _dbContext.SaveChanges();
            
            // Add CalendarObject to CalendarObjects in the way that the elements will not be errased
            SaveEverything();  
        }

        public static CalendarObj Load(Guid calendarId)
        {
            LoadEverything();
            var loadedCalendar = FindCalendarObj(calendarId);
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

        internal static List<CalendarObj> GetAllCalendarObjects()
        {
            return _dbContext.CalendarObjects.ToList();
        }
    }
}
