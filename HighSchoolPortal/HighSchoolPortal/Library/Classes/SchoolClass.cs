using System;
using System.Collections.Generic;

namespace HighSchoolPortal.Library.Classes
{
    public class SchoolClass
    {
        // TODO: Add Day of the Week and Period to this! They should probably be enums
        public int TeacherId { get; set; }
        public int Grade { get; set; }
        public string ClassName { get; set; }
        public Weekdays ClassDay { get; set; }
        public PeriodTimes ClassTime { get; set; }
        public string ClassDescription { get; set; }

        /// <summary>
        /// Default constructor for SchoolClass
        /// </summary>
        public SchoolClass()
        {
            this.TeacherId = 0;
            this.Grade = 0;
            this.ClassName = string.Empty;
            this.ClassDay = default(Weekdays);
            this.ClassTime = default(PeriodTimes);
            this.ClassDescription = string.Empty;
        }

        /// <summary>
        /// Basic Constructor for SchoolClass
        /// </summary>
        /// <param name="teacherId"></param>
        /// <param name="grade"></param>
        /// <param name="className"></param>
        public SchoolClass(int teacherId, int grade, string className, Weekdays weekday, PeriodTimes period)
        {
            this.TeacherId = teacherId;
            this.Grade = grade;
            this.ClassName = className;
            this.ClassDay = weekday;
            this.ClassTime = period;
            this.ClassDescription = string.Empty;
        }

        /// <summary>
        /// Create a SchoolClass from a string, broken along a given delimiter
        /// </summary>
        /// <param name="classCSV"></param>
        /// <param name="delimiter"></param>
        public SchoolClass(string classCSV, char delimiter = ',')
        {
            // Split csv string into a string array
            string[] classElements = classCSV.Split(delimiter);

            // Assign values from string array
            if (int.TryParse(classElements[0], out int parsedTeacherId))
                this.TeacherId = parsedTeacherId;
            if (int.TryParse(classElements[1], out int parsedGrade))
                this.Grade = parsedGrade;
            this.ClassName = classElements[2];
            if (Enum.TryParse(classElements[3], out Weekdays parsedClassDay))
                this.ClassDay = parsedClassDay;
            if (Enum.TryParse(classElements[4], out PeriodTimes parsedClassTime))
                this.ClassTime = parsedClassTime;
            this.ClassDescription = classElements[5];
        }

        /// <summary>
        /// Method to find whether the class's teacher is still present
        /// </summary>
        /// <returns></returns>
        public bool ValidateTeacherId()
        {
            // TODO: This is going to need some way to query all the teachers, and I'm not sure how that's going to go, so figure it out
            bool result = true;
            return result;
        }

        public override string ToString()
        {
            return this.ClassName;
        }
    }
}
