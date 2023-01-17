using Calendar.Models;
using Microsoft.EntityFrameworkCore;

namespace Calendar.Database
{
    internal class CalendarDbContext : DbContext
    {
        public DbSet<User> Users { get; set; };
        public DbSet<CalendarTask> CalendarTasks { get; set; }
        public DbSet<CalendarObj> CalendarObjects { get; set; }

        #region SINGLETON
        public static CalendarDbContext GetInstance()
        {
            var connectionString = "Data Source=sqlite.db";
            var optionsBuilder = new DbContextOptionsBuilder<CalendarDbContext>();
            optionsBuilder.UseSqlite(connectionString);
            return new CalendarDbContext(optionsBuilder.Options);
        }

        public CalendarDbContext(DbContextOptions<CalendarDbContext> options) : base (options)
        {

        }
        #endregion
    }
}
