using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static LmsData.Extensions.Enums;

namespace LmsData.Models
{

    public class MentorModel
    {
        public MentorModel()
        {

        }

        public MentorModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Speciality { get; set; }

        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime WWCCVerifiedDate { get; set; }
        [Required]
        public bool CanWorkWithChildren { get; set; } = false;
        public MentorStatus Status { get; set; } = MentorStatus.Full;

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string FullnameLastFirst
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

    }
}
