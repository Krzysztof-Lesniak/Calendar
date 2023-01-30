using Calendar;
using Calendar.Database;
using Calendar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CalendarWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalendarControler : ControllerBase
    {
        private readonly CalendarDbContext dbContext;

        public CalendarControler(CalendarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        //GET: api/CalendarObjects
        [HttpGet("GetAllCalendarObjects")]
        public IActionResult GetAllCalendarObjects()
        {
            return Ok(dbContext.CalendarObjects.ToList());
        }
        //GET: api/CalendarObjects/5
        [HttpGet("GetCalendarObject/{name}")]
        public IActionResult GetCalendarObject(string name)
        {
            return Ok(dbContext.CalendarObjects.FirstOrDefault(x => x.Name == name));
        }

        //POST: api/User
        [HttpPost("AddUser/{username}, {password}, {role}")]
        public void AddUser(string username, string password, role role)
        {
            dbContext.Users.Add(new User(username, password, role));
            dbContext.SaveChanges();
        }
        //Get: api/User/bool
        [HttpGet("IfUserExists/{username}")]
        public bool IfUserExists(string username)
        {
            return dbContext.Users.Any(x => x.UserName == username);
        }

        //Get: api/User/5
        [HttpGet("FindUser/{username}")]
        public IActionResult FindUser(string username)
        {
            return Ok(dbContext.Users.FirstOrDefault(x => x.UserName == username));
        }

        //Get: api/CalendarObj/bool
        [HttpGet("IsCalendarUsed/{id}")]
        public bool IsCalendarUsed(Guid id)
        {
            return dbContext.CalendarObjects.Any(x => x.Id == id);
        }

        //POST: api/User
        [HttpPost("Save{calendarToSave}")]
        public void Save(CalendarObj calendarToSave)
        {
            dbContext.CalendarObjects.Add(calendarToSave);
            dbContext.SaveChanges();
        }
        
        //POST: api/User
        [HttpPost("Update")]
        public void Update()
        {
            dbContext.SaveChanges();
        }

        //Get: api/CalendarObj
        [HttpGet("Load{CalendarToSave}")]
        public IActionResult Load(string calendarName)
        {
            var loadedCalendar = GetCalendarObject(calendarName);
            return loadedCalendar;
        }

        //Get: api/CalendarObj
        [HttpDelete("DeleteByName/{calendarName}")]
        public IActionResult DeleteByName(string calendarName)
        {
            var calendar = dbContext.CalendarObjects.Include(x => x.TaskList).FirstOrDefault(x => x.Name == calendarName);
            dbContext.CalendarTasks.RemoveRange(calendar.TaskList);
            dbContext.CalendarObjects.Remove(calendar);
            dbContext.SaveChanges();
            return Ok();
        }
        
        //Post: CalendarTask
        [HttpPost("AddTask/{calendarTask}")]
        public void AddTask(CalendarTask newCalendarTask)
        {
            dbContext.CalendarTasks.Add(newCalendarTask);
            dbContext.SaveChanges();
        }
    }
}
