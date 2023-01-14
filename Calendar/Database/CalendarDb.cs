using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Calendar.Models;

namespace Calendar.Database
{
    internal static class CalendarDb
    {
        public static List<User> Users { get; set; }
        public static List<CalendarTask> CalendarTasks { get; set; }
        public static int calLp { get; set; }

        static CalendarDb()
        {
            CalendarTasks = new List<CalendarTask>();
            calLp= 0;
        }
        
        public static void save()
        {
            calLp++;
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calLp.ToString() + ".bin");
            using (Stream stream = File.Open(fullPathOfFile, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, CalendarTasks);
            }
        }
        
        public static void Load(int calendarNumber)
        {
            
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calendarNumber.ToString() + ".bin");
            using (Stream stream = File.Open(fullPathOfFile, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();
                
                List<CalendarTask> CalendarTasks = (List<CalendarTask>)bformatter.Deserialize(stream);
            }

            
        }
        public static void Delete(int calendarNumber)
        {
            string dir = @"C:\Users\Krzysztof\source\repos\Calendar";
            string fullPathOfFile = Path.Combine(dir, "calendar_nr_" + calendarNumber.ToString() + ".bin");
            File.Delete(fullPathOfFile);
        }
    }
}
