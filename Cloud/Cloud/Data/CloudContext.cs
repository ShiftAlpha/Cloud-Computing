using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cloud.Models;

namespace Cloud.Data
{
    public class CloudContext : DbContext
    {
        public CloudContext (DbContextOptions<CloudContext> options)
            : base(options)
        {
        }

        public DbSet<Cloud.Models.Product> Product { get; set; }
    }
}
