namespace UserAndClassJsonSerializer.Library.Classes
{
    public class SchoolClass
    {
        public int TeacherId { get; set; }
        public int Grade { get; set; }
        public string ClassName { get; set; }

        /// <summary>
        /// Constructor for SchoolClass
        /// </summary>
        /// <param name="teacherId"></param>
        /// <param name="grade"></param>
        /// <param name="className"></param>
        public SchoolClass(int teacherId, int grade, string className)
        {
            this.TeacherId = teacherId;
            this.Grade = grade;
            this.ClassName = className;
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
    }
}
