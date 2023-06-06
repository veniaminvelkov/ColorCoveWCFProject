using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class ColorCoveDbContext : DbContext
    {
        public DbSet<Paint> Paints { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-MSMIQ5L\\SQLEXPRESS; Database = ColorCoveWCFProjectDb; Trusted_Connection=True; TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
