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
            model.Entity<Computers>().HasData(
                new Computers
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
                new Computers
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
                new Computers
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
        }
    }
}
