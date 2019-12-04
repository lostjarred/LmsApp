using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LmsData.Models
{
    public class IncidentModel
    {
        public int Id { get; set; }
        public DateTime OccuranceDate { get; set; }
        public virtual ICollection<MemberModel> MembersInvolved { get; set; }
        public string Details { get; set; }
        public int Type { get; set; }
        public MentorModel ReportedBy { get; set; }
    }
}

