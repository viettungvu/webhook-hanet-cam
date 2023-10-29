using Microsoft.EntityFrameworkCore;

namespace svInsertData.Models
{
    public class HRMDbContext : DbContext
    {
        public HRMDbContext()
        {
        }

        public HRMDbContext(DbContextOptions<HRMDbContext> options)
               : base(options)
        {
        }
        public DbSet<CheckinData> CheckinData { get; set; }
    }

    public class SqliteDbContext : DbContext
    {
        public SqliteDbContext()
        {

        }
        public SqliteDbContext(DbContextOptions<SqliteDbContext> options) : base(options)
        {

        }

        public DbSet<CheckinFail> CheckinData { get; set; }
    }
}
