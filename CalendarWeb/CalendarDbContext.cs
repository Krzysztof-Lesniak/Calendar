using Calendar.Models;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Database
{
    public class CalendarDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<CalendarTask> CalendarTasks { get; set; }
        public DbSet<CalendarObj> CalendarObjects { get; set; }

        public CalendarDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var connectionString = "Data Source=C:\\Users\\Krzysztof\\source\\repos\\Calendar\\Calendar\\SQlite.db";
            optionsBuilder.UseSqlite(connectionString);
        }
    }
}
