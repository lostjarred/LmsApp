using System;
using System.Collections.Generic;
using System.Text;

namespace LmsData.Extensions
{
    public static class Enums
    {

        public enum FormFactor
        {
            Desktop,
            Tower,
            Laptop,
            Tablet,
            Mini
        }

        public enum MentorStatus
        {
            Full = 1,
            Volunteer = 2,
            Discontinued = 3
        }

        public enum SessionType
        {
            Morning = 1,
            Noon = 2,
            All = 3
        }

        public enum IncidentType
        {
            AgressiveBehaviour = 1,
            DisobeyInstructions = 2,
            InappropriateLanguage = 3,
            Meltdown = 4,
            DisruptiveBehaviour = 5,
            NonCoOperativeBehaviour = 6
        }

        public enum ExpectationType
        {
            Parent = 1,
            Member = 2
        }
    }
}
