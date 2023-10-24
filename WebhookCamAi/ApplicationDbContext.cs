using Microsoft.EntityFrameworkCore;

namespace WebhookCamAi
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
               : base(options)
        {
        }
        public DbSet<CheckinData> CheckinData { get; set; }
    }

    public class FallbackDbContext : DbContext
    {
        public FallbackDbContext()
        {
            
        }
        public FallbackDbContext(DbContextOptions<FallbackDbContext> options):base(options)
        {
            
        }

        public DbSet<CheckinFail> CheckinData { get; set; }
    }
}
