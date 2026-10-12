using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Omar", 22, 95.5);

            s1.DisplayInfo();
            Console.WriteLine("*******************************");
            Student s2 = new Student("Ali", 25, 91.5);
            s2.DisplayInfo();
            Console.WriteLine("*******************************");
            Student s3 = new Student("Alaa", 20, 89.5);
            s3.DisplayInfo();


        }
    }
}
