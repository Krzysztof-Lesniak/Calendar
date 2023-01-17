using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class CalendarObj
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<CalendarTask> TaskList { get; set; } 
        public CalendarObj()
        {
            Id= Guid.NewGuid();
            TaskList = new List<CalendarTask>();
        }

    }
}
