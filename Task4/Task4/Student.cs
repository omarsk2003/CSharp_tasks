using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Student
    {
        public string name;
        public int age;
        public double grade;
        public Student(string n, int a, double g)
        {
            name = n;
            age = a;
            grade = g;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Student Name {name}");
            Console.WriteLine($"Student Age {age}");
            Console.WriteLine($"Student Grade {grade}");
        }





    }
}
