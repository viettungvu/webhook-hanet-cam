using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace svInsertData.Models
{
    public class MultiDbContexts
    {
        private Dictionary<string, IDbContextFactory> _dbContextFactories = new Dictionary<string, IDbContextFactory>();
        public MultiDbContexts(IServiceProvider serviceProvider)
        {
            foreach (var type in typeof(IDbContextFactory).Assembly.GetTypes())
            {
                if (typeof(IDbContextFactory).IsAssignableTo(type) && !type.IsInterface)
                {
                    _dbContextFactories.Add(type.Name.Replace("Factory", string.Empty), (IDbContextFactory)ActivatorUtilities.CreateInstance(serviceProvider, type));
                }
            }
        }
        public DbContext this[string index] => _dbContextFactories[index].DbContext;
    }
}
