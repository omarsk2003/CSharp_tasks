using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1062026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Part 1 ============");
            string Student_Name = "Ali";
            int Student_Age = 20;
            int Student_Grade = 12;
            double Student_Average = 85.5;
            char Student_Gender = 'M';
            bool Is_Student_Active = true;
            Console.WriteLine("===== Student Information =====");
            Console.WriteLine("Name: " + Student_Name);
            Console.WriteLine("Age: " + Student_Age);
            Console.WriteLine("Grade: " + Student_Grade);
            Console.WriteLine("Average: " + Student_Average);
            Console.WriteLine("Gender: " + Student_Gender);
            Console.WriteLine("Active: " + Is_Student_Active);

            
            
            Console.WriteLine("============ Part 2 ============");
            string[] Student_Names = { "Ali", "Ahmed", "Sara", "Omar" };
            Console.WriteLine("===== Student Names =====");
            Console.WriteLine("Student 1: " + Student_Names[0]);
            Console.WriteLine("Student 2: " + Student_Names[1]);
            Console.WriteLine("Student 3: " + Student_Names[2]);
            Console.WriteLine("Student 4: " + Student_Names[3]);
            Console.WriteLine("Number of Students = "+ Student_Names.Length);
           
            
            
            
            Console.WriteLine("============ Part 3 ============");
        
            Console.WriteLine("===== Before Change =====");
            Console.WriteLine("First Student: " + Student_Names[0]);
            Console.WriteLine("Second Student: " + Student_Names[1]);
            Console.WriteLine("Third Student: " + Student_Names[2]);
            Console.WriteLine("Last Student: " + Student_Names[3]);
            Student_Names[0] = "Mohammed";
            Student_Names[1] = " Fatima";
            Console.WriteLine("===== After Change =====");
            Console.WriteLine("First Student: " + Student_Names[0]);
            Console.WriteLine("Second Student: " + Student_Names[1]);
            Console.WriteLine("Third Student: " + Student_Names[2]);
            Console.WriteLine("Last Student: " + Student_Names[3]);

        }
    }
}
