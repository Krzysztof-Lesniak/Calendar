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
            return _dbContext.CalendarObjects.FirstOrDefault(x => x.Name == calendarName);
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

        public static bool IsCalendarNameUsed(string userName) 
        {
            return _dbContext.Users.Any(x =>x.UserName == userName);
        }
        public static void Save(CalendarObj calendarToSave) //ivoked when calendar is new
        {
            _dbContext.CalendarObjects.Add(calendarToSave);
            _dbContext.SaveChanges();
        }
        public static void Update(CalendarObj calendarToSave) //ivoked when calendar is loaded
        {
            var tempCalendar = _dbContext.CalendarObjects.FirstOrDefault(x => x.Id == calendarToSave.Id);
            foreach (var task in calendarToSave.TaskList)
            {
                if (tempCalendar.TaskList.Any(x => x.Id != task.Id))
                {
                    tempCalendar.TaskList.Add(task);
                }
            }
            foreach (var task in tempCalendar.TaskList)
            {
                if (calendarToSave.TaskList.Any(x => x.Id != task.Id))
                {
                    tempCalendar.TaskList.Remove(task);
                }
            }
            
            
            _dbContext.SaveChanges();
        }

        public static CalendarObj Load(string calendarName)
        {
            var loadedCalendar = FindCalendarObj(calendarName);
            return loadedCalendar;


        }
        public static void Delete(string calendarName)
        {
            var calendar = _dbContext.CalendarObjects.FirstOrDefault(x => x.Name == calendarName);
            _dbContext.CalendarObjects.Remove(calendar);
            _dbContext.SaveChanges();
        }
        internal static List<CalendarObj> GetAllCalendarObjects()
        {
            return _dbContext.CalendarObjects.ToList();
        }
    }
}
