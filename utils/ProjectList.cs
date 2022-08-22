

using System.Text.Json;
using System;

namespace Portfalio.utils

{
    public class Person
    {
        public string ProjectName { get; set; }
        public string Details { get; set; }
        public string Framework { get; set; }
    }

    public class ProjectList
    {
        static void Main(string[] args)
        {
            List<Person> projectList = new List<Person>();

            using (StreamReader r = new StreamReader("projectList.json"))
            {
                string json = r.ReadToEnd();
                projectList = JsonSerializer.Deserialize<List<Person>>(json);
                
            
            }


        }

        }
}
