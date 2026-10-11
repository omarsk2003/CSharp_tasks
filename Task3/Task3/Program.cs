using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Task3
{
    internal class Program
    {

        static void serstu(string[] arr,string selectname) {
            for (int i=0;i<arr.Length ; i++) 
            {
                if (arr[i] == selectname)
                {
                    Console.WriteLine("Student found");
                    Console.WriteLine(selectname);
                    break;
                }
                else
                {
                    Console.WriteLine("Student not found please try again");
                }
            
            }


        }

        static void stgrade(int x) {

            if (90<=x&&x<=100)
            {
                Console.WriteLine("Exelent");
            }
            else if (80<=x&&x<90)
            {
                Console.WriteLine("Very Good");
            }
            else if (70<=x&&x<80)
            {
                Console.WriteLine("Good");
            }
            else if (60<=x&& x<70)
            {
                Console.WriteLine("Pass");
            }
            else { Console.WriteLine("Fail"); }



        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!");
            int numtoguess = 65;
            int attempts = 0;
            int points = 10;
            while (true)
            {

                attempts++;
                Console.WriteLine("Guess the number between 50 and 70:");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess < numtoguess)
                {
                    Console.WriteLine("Too low! Try again.");
                    points = points - 3;

                }
                else if (guess > numtoguess)
                {
                    Console.WriteLine("Too high! Try again.");
                    points = points - 3;

                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    Console.WriteLine($"You used {attempts} attempts and have {points} points.");

                    break;
                }

            }

            Console.WriteLine("School System.");
            string[] students = { "Alice", "Bob", "Omar", "David" };
            int[] grades = { 85, 92, 78, 90, 88 };
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"Student Name: {students[i]}");
            }
            foreach (int grade in grades)
            {
                Console.WriteLine($"Grade: {grade}");
            }

            Console.WriteLine("menu");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("please enter from menu \n 1. Display Students \n 2. Search for Student \n 3. Check Student Result \n 4. Exit");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input) { 
                case 1:
                        for (int i = 0; i < students.Length; i++)
                        {
                            Console.WriteLine($"Student Name: {students[i]}");
                        }
                        break;
                case 2:
                        Console.WriteLine("Please enter name of student");
                        string sename = Console.ReadLine();
                        serstu(students,sename);
                break;
                case 3:
                        Console.WriteLine("Please enter Grade of student");
                        int segrade =Convert.ToInt32(Console.ReadLine());
                        stgrade(segrade);
                        break;
                    default:
                        flag = false;   
                     break;

                }

            }
        }
    }
}