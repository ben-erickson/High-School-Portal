using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace HighSchoolPortal.Library.Classes
{
    /// <summary>
    /// A container class for User that splits the Users into students and faculty
    /// </summary>
    class UserBody
    {
        public List<User> StudentList { get; set; }
        public List<User> FacultyList { get; set; }

        public UserBody(string filepath)
        {
            foreach(string line in File.ReadAllLines(filepath))
            {
                User user = JsonConvert.DeserializeObject<User>(line);

                if (user.PowerLevel == PowerLevel.Student)
                {
                    StudentList.Add(user);
                }
                else
                {
                    FacultyList.Add(user);
                }
            }
        }
    }
}
