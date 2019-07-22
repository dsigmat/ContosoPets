using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ContosoPets.Models
{
    public class ContosoPetsContext : DbContext
    {
        public ContosoPetsContext (DbContextOptions<ContosoPetsContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoPets.Models.Product> Product { get; set; }
    }
}
