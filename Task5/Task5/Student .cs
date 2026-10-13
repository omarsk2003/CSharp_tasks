using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
     class Student:Person
    {
       
        public string StuSchoolName 
        {
            get { return SchoolName; } set { SchoolName = value; }
        }
        public static int gradeStudent { set; get; }
        public Student(string n,int a,string sh):base(n,a) { SchoolName = sh;         }
       
        public int id;
        public int Id
            { set { id = id++; }
            

            get
            { return id; }
                }

        public void DisplayStuInfo() 
        {
            Console.WriteLine($"{ Name}");
            Console.WriteLine($"{Age}");
            Console.WriteLine($"{SchoolName}");
            Console.WriteLine($"{gradeStudent}");


        }
    }
}
