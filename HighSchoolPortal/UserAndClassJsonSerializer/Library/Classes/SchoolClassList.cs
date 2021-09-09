using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace UserAndClassJsonSerializer.Library.Classes
{
    public class SchoolClassList
    {
        public List<SchoolClass> ClassList { get; set; }

        public SchoolClassList(string filepath)
        {
            foreach (string line in File.ReadAllLines(filepath))
            {
                this.ClassList.Add(JsonConvert.DeserializeObject<SchoolClass>(line));
            }
        }
    }
}
