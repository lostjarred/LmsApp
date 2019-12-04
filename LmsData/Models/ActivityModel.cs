using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LmsData.Models
{
    public class ActivityModel
    {
        public int Id { get; set; }

        [Display(Name="Activity Start Date")]
        public DateTime? StartDate { get; set; }

        [Display(Name = "Activity End Date")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Current Activity?")]
        public bool IsCurrent { get; set; } = true;
        public string Name { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }
        public string Port { get; set; }

    }
}
