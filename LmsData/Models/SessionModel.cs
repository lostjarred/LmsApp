using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static LmsData.Extensions.Enums;

namespace LmsData.Models
{
    public class SessionModel
    {
        public SessionModel()
        {
            Attendees = new List<MemberModel>();
            Incidents = new List<IncidentModel>();
        }

        public int Id { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; } = DateTime.Now.Date;
        [Required]
        public SessionType SessionType { get; set; }
        public virtual List<MemberModel> Attendees { get; set; }
        public virtual List<IncidentModel> Incidents { get; set; }
        public string Notes { get; set; }



    }
}
