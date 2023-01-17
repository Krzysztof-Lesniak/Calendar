using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    internal class CalendarObj
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CalendarTask> TaskList { get; set; }
        public CalendarObj(int id)
        {
            Id= id;
        }

    }
}
