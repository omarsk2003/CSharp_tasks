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
            string StudentName = Console.ReadLine();
            Console.WriteLine("Enter your age:");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your grade:");
            char StudentGrade = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter your average:");
            double StudentAverage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your gender:");
            string StudentGender = Console.ReadLine();
            Console.WriteLine("Your information is:");
            Console.WriteLine($"Welcome {StudentName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {StudentGrade}");
            Console.WriteLine($"Average: {StudentAverage}");
            Console.WriteLine($"Gender: {StudentGender}");
            Console.WriteLine("*****************************");
            Console.WriteLine($"Original Name: {StudentName}");
            Console.WriteLine($"Uppercase Name: {StudentName.ToUpper()}");
            Console.WriteLine($"Lowercase Name: {StudentName.ToLower()}");
            Console.WriteLine($"First Letter: {StudentName[0]}");
            Console.WriteLine("******************************");
            Console.WriteLine($"Original Average: {StudentAverage}");
            Console.WriteLine($"Bouns: 5");
            double NewAverage = StudentAverage + 5;
            Console.WriteLine($"New Average: {NewAverage}");
            Console.WriteLine("******************************");
            string result;
            if(NewAverage >= 50)
            {
              result = "Congratulations! You have passed.";
              Console.WriteLine(result);
            }
            else
            {
                result = "Sorry, you have failed.";
                Console.WriteLine(result);
            }
            string msg;
            if(Age >= 18)
            {
                msg = "You are an adult.";
                Console.WriteLine(msg);
            }
            else
            {
                 msg = "You are not an adult.";
                Console.WriteLine(msg);
            }
            Console.WriteLine(" STUDENT SUMMARY");
            Console.WriteLine($"Name: {StudentName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {StudentGrade}");
            Console.WriteLine($"Average: {StudentAverage}");
            Console.WriteLine($"New Average: {NewAverage}");
            Console.WriteLine($"Gender: {StudentGender}");
            Console.WriteLine(msg);
            Console.WriteLine(result);
        }
    }
}
