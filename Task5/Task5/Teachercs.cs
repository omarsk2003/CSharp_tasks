using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Teachercs : Person
    {
        public string Subject { get; set; }
    
        public Teachercs(string n,int a,string s):base(n,a)
        {
            Subject = s;
        }
    public void DisplayTeacherInfo()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Age}");
            Console.WriteLine($"{Subject}");
        }
    }
}
