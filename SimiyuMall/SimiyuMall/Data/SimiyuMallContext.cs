using Microsoft.EntityFrameworkCore;
using SimiyuMall.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimiyuMall.Data
{
    public class SimiyuMallContext: DbContext
    {
        public SimiyuMallContext(DbContextOptions<SimiyuMallContext> options): base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
