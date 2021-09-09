using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace UserAndClassJsonSerializer.Library.Classes
{
    /// <summary>
    /// A container class for User that splits the Users into students and faculty
    /// </summary>
    public class UserBody
    {
        public List<User> StudentList { get; set; }
        public List<User> FacultyList { get; set; }

        public UserBody(string filepath)
        {
            foreach (string line in File.ReadAllLines(filepath))
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
    }
}
