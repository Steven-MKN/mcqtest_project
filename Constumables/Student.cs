using System.Collections.Generic;

namespace Consumables
{
    public class Student
    {
        public string Username { get; set; }
        public string LongName { get; set; }
        public List<Test> Tests;

        public Student(string username, string longname)
        {
            this.Username = username;
            this.LongName = longname;
            Tests = new List<Test>();
        }
    }
}
