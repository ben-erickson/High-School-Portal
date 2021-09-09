using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace HighSchoolPortal.Library.Classes
{
    class SchoolClassList
    {
        public List<SchoolClass> ClassList { get; }

        private static string _classFile = "C:\\Users\\berickson\\source\\repos\\High School Portal\\High-School-Portal\\HighSchoolPortal\\HighSchoolPortal\\data\\classFile.json";
        private static SchoolClassList _instance;

        private SchoolClassList()
        {
            this.ClassList = new List<SchoolClass>();
            foreach (string line in File.ReadAllLines(_classFile))
            {
                this.ClassList.Add(JsonConvert.DeserializeObject<SchoolClass>(line));
            }
        }

        public static SchoolClassList GetInstance()
        {
            // NOTE: This is NOT THREAD SAFE!! When you implement multithreading, update this to become thread safe
            if (_instance == null)
            {
                _instance = new SchoolClassList();
            }
            return _instance;
        }
    }
}
