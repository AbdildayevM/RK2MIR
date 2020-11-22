using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RK2MIR.Models;

namespace RK2MIR.Data
{
    public class RK2MIRContext : DbContext
    {
        public RK2MIRContext (DbContextOptions<RK2MIRContext> options)
            : base(options)
        {
        }

        public DbSet<RK2MIR.Models.Client> Client { get; set; }

        public DbSet<RK2MIR.Models.Employee> Employee { get; set; }

        public DbSet<RK2MIR.Models.Food> Food { get; set; }

        public DbSet<RK2MIR.Models.News> News { get; set; }

        public DbSet<RK2MIR.Models.Order> Order { get; set; }

        public DbSet<RK2MIR.Models.Partners> Partners { get; set; }
    }
}
