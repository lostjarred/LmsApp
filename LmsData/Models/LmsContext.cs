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

        public DbSet<ComputerModel> Computers { get; set; }
        public DbSet<MentorModel> Mentors { get; set; }
        public DbSet<MemberModel> Members { get; set; }
        public DbSet<IncidentModel> Incidents { get; set; }
        public DbSet<SessionModel> Sessions { get; set; }
        public DbSet<IssueModel> KnownIssues { get; set; }
        public DbSet<ExpectationModel> Expectations { get; set; }
        public DbSet<ActivityModel> Activities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

    }
}
