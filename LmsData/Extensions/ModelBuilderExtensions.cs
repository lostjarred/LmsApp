using LmsData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using static LmsData.Extensions.Enums;

namespace LmsData.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder model)
        {
            // Create seed data for computers
            model.Entity<ComputerModel>().HasData(
                new ComputerModel
                {
                    Id=1,
                    Brand="Lenovo",
                    Model="",
                    RamInMegabytes=4096,
                    Processor="Pentium Core2 Duo",
                    HddSize="500Gb",
                    SerialNumber="LEN-123",
                    OperatingSystem="Windows 10 Pro",
                    CaseType=FormFactor.Laptop,
                    DateReceived=DateTime.Parse("2019-06-30"),
                    TestDate=DateTime.Parse("2019-08-15"),
                    TestedBy="Riley"
                    },
                new ComputerModel
                {
                    Id = 2,
                    Brand = "Lenovo",
                    Model = "",
                    RamInMegabytes = 4096,
                    Processor = "Pentium Core2 Duo",
                    OperatingSystem = "Windows 10 Pro",
                    HddSize="250Gb",
                    SerialNumber="LEN-3452",
                    CaseType = FormFactor.Laptop,
                    DateReceived = DateTime.Parse("2019-06-30"),
                    TestDate = DateTime.Parse("2019-08-15"),
                    TestedBy = "Riley"
                },
                new ComputerModel
                {
                    Id = 3,
                    Brand = "Dell",
                    Model = "Optiplex 610",
                    RamInMegabytes = 4096,
                    Processor = "Pentium Core i3 Gen 4",
                    OperatingSystem = "Ubuntu 19.04 Desktop",
                    HddSize = "500Gb",
                    SerialNumber = "LEN-3452",
                    CaseType = FormFactor.Desktop,
                    DateReceived = DateTime.Parse("2019-06-30"),
                    TestDate = DateTime.Parse("2019-08-15"),
                    TestedBy = "Jarred"
                }
            );

            // Create seed data for Members
            model.Entity<MemberModel>().HasData(
                 new MemberModel
                 {
                     Id = 1,
                     FirstName = "Brodie",
                     LastName = "O'Hara",
                     DateOfBirth = DateTime.Parse("2006-06-26"),
                     DateEnrolled = DateTime.Parse("2019-06-15"),
                     BookedSession = SessionType.All,
                     IsActive = true,
                     Expectations = new List<ExpectationModel>(),
                     KnownIssues = new List<IssueModel>()
                 },
                 new MemberModel
                 {
                     Id = 2,
                     FirstName = "Tyreece",
                     LastName = "Dureaux",
                     DateOfBirth = DateTime.Parse("2004-07-31"),
                     DateEnrolled = DateTime.Parse("2019-06-15"),
                     BookedSession = SessionType.Morning,
                     IsActive = true,
                     Expectations = new List<ExpectationModel>(),
                     KnownIssues = new List<IssueModel>()
                 },
                 new MemberModel
                 {
                     Id = 3,
                     FirstName = "Dexter",
                     LastName = "McMahon",
                     DateOfBirth = DateTime.Parse("2010-09-02"),
                     DateEnrolled = DateTime.Parse("2019-06-15"),
                     BookedSession = SessionType.Morning,
                     IsActive = true,
                     Expectations = new List<ExpectationModel>(),
                     KnownIssues = new List<IssueModel>()
                 },
                 new MemberModel
                 {
                     Id = 4,
                     FirstName = "Sonnie",
                     LastName = "Jones",
                     DateOfBirth = DateTime.Parse("2009-02-24"),
                     DateEnrolled = DateTime.Parse("2019-06-15"),
                     BookedSession = SessionType.Morning,
                     IsActive = true,
                     Expectations = new List<ExpectationModel>(),
                     KnownIssues = new List<IssueModel>()
                 },
                 new MemberModel
                 {
                     Id = 5,
                     FirstName = "Lilly",
                     LastName = "Fletcher",
                     DateOfBirth = DateTime.Parse("2007-09-08"),
                     DateEnrolled = DateTime.Parse("2019-06-15"),
                     BookedSession = SessionType.Noon,
                     IsActive = true,
                     Expectations = new List<ExpectationModel>(),
                     KnownIssues = new List<IssueModel>()
                 });

            // Create seed data for Expectations
            model.Entity<ExpectationModel>().HasData(

                // MemberId 1 - Brodie
                new ExpectationModel
                {
                    Id = 1,
                    MemberId = 1,
                    Description = "Brodie is Bob's Grandson",
                    Type = ExpectationType.Parent
                },
                new ExpectationModel
                {
                    Id = 2,
                    MemberId = 1,
                    Description = "Brodie is enrolled in both sessions",
                    Type = ExpectationType.Member
                },
                // MemberId 2 - Tyreece
                new ExpectationModel
                {
                    Id = 3,
                    MemberId = 2,
                    Description = "Tyreece Parent Expectation 1",
                    Type = ExpectationType.Parent
                },
                // Dexter
                new ExpectationModel
                {
                    Id = 4,
                    MemberId = 3,
                    Description = "Dex likes coding and Minecraft",
                    Type = ExpectationType.Member
                }
                );

            // Create seed data for Known Issues
            model.Entity<IssueModel>().HasData(
                new IssueModel
                {
                    Id = 1,
                    MemberId = 1,
                    Description = "Brodie does not like a lot of noise"
                },

                new IssueModel
                {
                    Id = 2,
                    MemberId = 3,
                    Description = "Dex is a bit shy"
                },
                new IssueModel
                {
                    Id = 3,
                    MemberId = 2,
                    Description = "Has OCD"
                },
                new IssueModel
                 {
                     Id = 4,
                     MemberId = 2,
                     Description = "Has ADHD"
                 },
                new IssueModel
                  {
                      Id = 5,
                      MemberId = 4,
                      Description = "Very talkative"
                  }
                );

            // Create seed data for Mentors
            model.Entity<MentorModel>().HasData(
                new MentorModel
                {
                    Id = 1,
                    FirstName = "Steve",
                    LastName = "Teece",
                    Email = "steve@thelab.grafton.internal",
                    Mobile = "(0421) 420-141",
                    Speciality = "Programming",
                    WWCCVerifiedDate = DateTime.Parse("2019-09-26"),
                    CanWorkWithChildren = true,
                    Status = MentorStatus.Full
                },
                new MentorModel
                {
                    Id = 2,
                    FirstName = "Duncan",
                    LastName = "Sage",
                    Email = "duncan@thelab.grafton.internal",
                    Mobile = "",
                    Speciality = "3D Graphics",
                    WWCCVerifiedDate = DateTime.Parse("2019-06-22"),
                    CanWorkWithChildren = true,
                    Status = MentorStatus.Full
                },
                new MentorModel
                {
                    Id = 3,
                    FirstName = "Jarred",
                    LastName = "Chaffey",
                    Email = "jarred@thelab.grafton.internal",
                    Mobile = "",
                    Speciality = "Hardware",
                    WWCCVerifiedDate = DateTime.Parse("2019-06-22"),
                    CanWorkWithChildren = true,
                    Status = MentorStatus.Volunteer
                },
                new MentorModel
                {
                    Id = 4,
                    FirstName = "Mark",
                    LastName = "Bathgate",
                    Email = "mark@thelab.grafton.internal",
                    Mobile = "",
                    Speciality = "",
                    WWCCVerifiedDate = DateTime.Parse("2019-06-22"),
                    CanWorkWithChildren = true,
                    Status = MentorStatus.Discontinued
                },
                new MentorModel
                {
                    Id = 5,
                    FirstName = "Ben",
                    LastName = "McKenzie",
                    Email = "ben@thelab.grafton.internal",
                    Mobile = "",
                    Speciality = "Gaming",
                    WWCCVerifiedDate = DateTime.Parse("2019-06-22"),
                    CanWorkWithChildren = true,
                    Status = MentorStatus.Volunteer
                }
            );
        }
    }
}
