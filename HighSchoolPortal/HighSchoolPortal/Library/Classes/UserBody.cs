using HighSchoolPortal.Library.Enumerations;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HighSchoolPortal.Library.Classes
{
    /// <summary>
    /// A container class for User that splits the Users into students and faculty
    /// </summary>
    class UserBody
    {
        public List<User> StudentList { get; }
        public List<User> FacultyList { get; }
        private static string _userFile = "C:\\Users\\berickson\\source\\repos\\High School Portal\\High-School-Portal\\HighSchoolPortal\\HighSchoolPortal\\data\\userFile.json";
        private static UserBody _instance;
        private UserBody()
        {
            this.StudentList = new List<User>();
            this.FacultyList = new List<User>();

            foreach (string line in File.ReadAllLines(_userFile))
            {
                User user = JsonConvert.DeserializeObject<User>(line);

                if (user.PowerLevel == PowerLevel.Student)
                {
                    this.StudentList.Add(user);
                }
                else
                {
                    this.FacultyList.Add(user);
                }
            }
        }

        public static UserBody GetInstance()
        {
            // NOTE: This is NOT THREAD SAFE!! When you implement multithreading, update this to become thread safe
            if (_instance == null)
            {
                _instance = new UserBody();
            }
            return _instance;
        }
    }
}
