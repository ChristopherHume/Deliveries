using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Loaner.Models;

namespace Deliveries.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Item>().HasData(
                    new Item() { Id = 1, Name = "Test", Weight = 1 }
                ); 
        }
        */

        public DbSet<Loaner.Models.Item> Item { get; set; }
        public DbSet<Loaner.Models.Customer> Customer { get; set; }
        public DbSet<Loaner.Models.Delivery> Delivery { get; set; }
    }
}
