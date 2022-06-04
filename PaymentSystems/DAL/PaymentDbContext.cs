using ENTITIES;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class PaymentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=PaymentSystemsDb;Integrated Security=True");
        }

        public DbSet<Payment> Payments { get; set; }
        public DbSet<Bank> Banks { get; set; }
    }
}
