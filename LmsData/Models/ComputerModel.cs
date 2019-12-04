using System;
using System.Collections.Generic;
using System.Text;
using static LmsData.Extensions.Enums;

namespace LmsData.Models
{
    public class Computers
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int RamInMegabytes { get; set; }
        public string Processor { get; set; }

        public string OperatingSystem { get; set; }
        public string HddSize { get; set; }
        public string Notes { get; set; }
        public FormFactor CaseType { get; set; }
        public string SerialNumber { get; set; }
        public DateTime DateReceived { get; set; }
        public string TestedBy { get; set; }
        public DateTime TestDate { get; set; }

    }
}
