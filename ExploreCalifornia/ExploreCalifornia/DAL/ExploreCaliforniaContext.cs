using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;
using Microsoft.EntityFrameworkCore;

namespace ExploreCalifornia.DAL
{
    public class ExploreCaliforniaContext : DbContext
    {
        public ExploreCaliforniaContext(DbContextOptions<ExploreCaliforniaContext> options) : base(options) { }

        public ExploreCaliforniaContext() : base() { }

        public DbSet<Tours> Tours { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tours>().ToTable("Tours");
        }


        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ExploreCaliforniaDB;Trusted_Connection=True;MultipleActiveResultSets=true");
            base.OnConfiguring(builder);
        }
    }
}
