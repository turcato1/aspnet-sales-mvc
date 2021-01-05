using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSalesWebMvc.Models;

namespace NSalesWebMvc.Data
{
    public class NSalesWebMvcContext : DbContext
    {
        public NSalesWebMvcContext (DbContextOptions<NSalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
        public DbSet<Seller> Seller { get; set; }

    }
}
