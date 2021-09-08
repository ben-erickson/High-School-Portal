using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace UserAndClassJsonSerializer.Library.Classes
{
    public class SchoolClassList
    {
        public List<SchoolClass> ClassList { get; set; }

        public SchoolClassList(string filepath)
        {
            foreach (string line in File.ReadAllLines(filepath))
            {
                ClassList.Add(JsonConvert.DeserializeObject<SchoolClass>(line));
            }
        }
    }
}
