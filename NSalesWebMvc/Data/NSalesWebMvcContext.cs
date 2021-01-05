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

        public DbSet<NSalesWebMvc.Models.Department> Department { get; set; }
    }
}
