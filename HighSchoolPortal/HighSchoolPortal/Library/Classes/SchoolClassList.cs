using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HighSchoolPortal.Library.Classes
{
    class SchoolClassList
    {
        public List<SchoolClass> ClassList { get; }

        private const string s_CLASSFILE = "C:\\Users\\berickson\\source\\repos\\High School Portal\\High-School-Portal\\HighSchoolPortal\\HighSchoolPortal\\data\\classFile.json";

        /// <summary>
        /// Default constructor for SchoolClassList
        /// </summary>
        public SchoolClassList()
        {
            this.ClassList = new List<SchoolClass>();
            foreach (string line in File.ReadAllLines(s_CLASSFILE))
            {
                this.ClassList.Add(JsonConvert.DeserializeObject<SchoolClass>(line));
            }
        }

        /// <summary>
        /// Constructor for SchoolClassList taking a file and breaking it into a list of SchoolClass objects
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="delimiter"></param>
        public SchoolClassList(string filepath, char delimiter = ',')
        {

        }
    } 

}
