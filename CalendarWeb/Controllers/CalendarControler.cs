using Calendar.Database;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace CalendarWeb.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalendarControler : ControllerBase
    {
        private readonly CalendarDbContext dbContext;

        public CalendarControler(CalendarDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return Ok(dbContext.CalendarObjects.ToList());
        }
    }
}
