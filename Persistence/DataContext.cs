using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Values { get; set; }

        protected override void OnModelCreating(ModelBuilder build)
        {

            build.Entity<Value>()
            .HasData(

                new Value { Id = 1, Name = "Mrinal" },
                 new Value { Id = 2, Name = "Sonaal" },
                  new Value { Id = 3, Name = "Babuni" }
            );

        }
    }
}
