﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using static LmsData.Extensions.Enums;

namespace LmsData.Models
{
    /// <summary>
    /// Member class
    /// </summary>
    public class MemberModel
    {
        private DateTime dateEnrolled;
        private DateTime dateOfBirth;

        public MemberModel()
        {
            
        }

        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth.Date;
            }
            set
            {
                dateOfBirth = value;
            }
        }
        public int AgeInYears
        {
            get
            {
                var age = (DateTime.Today.Year - DateOfBirth.Date.Year);
                return age;
            }
        }

        public virtual ICollection<ExpectationModel> Expectations { get; set; }
        public virtual ICollection<IssueModel> KnownIssues { get; set; }
        public DateTime DateEnrolled
        {
            get
            {
                return dateEnrolled.Date;
            }
            set
            {
                dateEnrolled = value;
            }
        }
        public string PhotoPath { get; set; }
        public SessionType BookedSession { get; set; }

        [Required]
        [Display(Name = "Is Active?")]
        public bool IsActive { get; set; } = true;

        [Required]
        [Display(Name = "Is Cadet?")]
        public bool IsCadet { get; set; } = false;

        //public virtual ICollection<Incident> Incidents { get; set; }
        //public virtual ICollection<Session> SessionsAttended { get; set; }

        public string Notes { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        /// <summary>
        /// Output the full name, Last name first.
        /// </summary>
        public string FullnameLastFirst
        {
            get
            {
                return $"{LastName}, {FirstName}";
            }
        }

        /// <summary>
        /// Override default ToString() method to output full name
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return FullName;
        }

    }
}
