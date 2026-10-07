using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7102026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string StudentName= Console.ReadLine();
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your grade:");
            char StudentGrade = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your average:");
            double StudentAverage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your gender:");
            string StudentGender = Console.ReadLine();
            Console.WriteLine("Your information is:");
            Console.WriteLine(StudentName);
            Console.WriteLine(number);
            Console.WriteLine(StudentGrade);
            Console.WriteLine(StudentAverage);
            Console.WriteLine(StudentGender);

        }
    }
}
