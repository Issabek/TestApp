using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TestApp.Models;

namespace TestApp.Data
{
    public class KazakhstanContext : DbContext
    {
        public KazakhstanContext (DbContextOptions<KazakhstanContext> options)
            : base(options)
        {
        }

        public DbSet<Resident> Residents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Resident>().ToTable("Resident");
        }
    }
}
