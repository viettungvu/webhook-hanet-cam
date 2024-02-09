using Infra.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.EF
{
    public class HRMLogDbContext : DbContext
    {
        public HRMLogDbContext()
        {

        }
        public HRMLogDbContext(DbContextOptions<HRMLogDbContext> options) : base(options)
        {

        }

        public DbSet<CheckinFail> CheckinData { get; set; }
    }
}
