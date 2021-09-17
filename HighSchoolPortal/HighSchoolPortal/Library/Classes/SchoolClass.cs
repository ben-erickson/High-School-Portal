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

        /// <summary>
        /// Constructor for SchoolClass
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
