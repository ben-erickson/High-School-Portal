using HighSchoolPortal.Library.Enumerations;

namespace HighSchoolPortal.Library.Classes
{
    public class User
    {
        public PowerLevel PowerLevel { get; set; }
        public int? TeacherId { get; set; }
        public int? Grade { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Constructor for User
        /// </summary>
        /// <param name="powerLevel"></param>
        /// <param name="grade"></param>
        /// <param name="teacherId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public User(PowerLevel powerLevel, int? grade, int? teacherId, string username, string password)
        {
            this.PowerLevel = powerLevel;

            if (powerLevel == PowerLevel.Teacher)
            {
                this.TeacherId = teacherId;
                this.Grade = null;
            }
            else
            {
                this.Grade = grade;
                this.TeacherId = null;
            }

            this.Username = username;
            this.Password = password;
        }
    }
}
