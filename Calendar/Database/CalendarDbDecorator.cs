using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Calendar.Models;
using Microsoft.EntityFrameworkCore;
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
            foreach (var calendar in _dbContext.CalendarObjects)
            {
                if(calendar.Name == null)
                {
                    var rand = new Random();
                    var stringRand = rand.Next().ToString();
                    calendar.Name = stringRand;
                }
            }
        }

        public static CalendarObj FindCalendarObj(string calendarName)
        {
            using var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7030/CalendarControler/GetCalendarObject/" + calendarName).Result;
            var allCalendarObjectsString = response.Content.ReadAsStringAsync().Result;
            var allCalendarObjects = JsonConvert.DeserializeObject<CalendarObj>(allCalendarObjectsString);

            return _dbContext.CalendarObjects.Include(x => x.TaskList).FirstOrDefault(x => x.Name == calendarName);
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

        public static bool IsCalendarIdUsed(Guid id) 
        {
            return _dbContext.CalendarObjects.Any(x => x.Id == id);
        }
        public static void Save(CalendarObj calendarToSave) //ivoked when calendar is new
        {
            _dbContext.CalendarObjects.Add(calendarToSave);
            _dbContext.SaveChanges();
        }

        public static void Update()
        {
            _dbContext.SaveChanges();
        }
      

        public static CalendarObj Load(string calendarName)
        {
            var loadedCalendar = FindCalendarObj(calendarName);
            return loadedCalendar;
        }
        public static void DeleteByName(string calendarName)
        {
            var calendar = _dbContext.CalendarObjects.Include(x => x.TaskList).FirstOrDefault(x => x.Name == calendarName);
            _dbContext.CalendarTasks.RemoveRange(calendar.TaskList);
            _dbContext.CalendarObjects.Remove(calendar);
            _dbContext.SaveChanges();
        }
        internal static List<CalendarObj> GetAllCalendarObjects()
        {
            using var client = new HttpClient();
            var response = client.GetAsync("https://localhost:7030/CalendarControler/GetAllCalendarObjects").Result;
            var allCalendarObjectsString = response.Content.ReadAsStringAsync().Result;
            var allCalendarObjects = JsonConvert.DeserializeObject<List<CalendarObj>>(allCalendarObjectsString);

            return allCalendarObjects;
        }

        internal static void AddTask(CalendarTask newCalendarTask)
        {
            _dbContext.CalendarTasks.Add(newCalendarTask);
            _dbContext.SaveChanges();
        }
    }
}
