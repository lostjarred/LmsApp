using LmsData.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LmsData.Models
{
    public class LmsContext : DbContext
    {
        public LmsContext(DbContextOptions<LmsContext> options)
            : base(options)
        {

        }

        public DbSet<Computers> Computers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
