using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace svInsertData.Models
{
    public interface IDbContextFactory
    {
        DbContext DbContext { get; }
    }
    public class HrmContextFactory : IDbContextFactory
    {
        public DbContext DbContext { get; }
        public HrmContextFactory(HRMDbContext hrmDbContext)
        {
            DbContext = hrmDbContext;
        }
    }
    public class SqliteDbContextFactory : IDbContextFactory
    {
        public DbContext DbContext { get; }
        public SqliteDbContextFactory(SqliteDbContext sqliteDbContext)
        {
            DbContext = sqliteDbContext;
        }
    }
}
