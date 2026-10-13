using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
     class Person
    {
        private string _internalCode= "This Field can not be access in other calsses because it have a private Access Modifier";
       protected string SchoolName{ get; set; }
        public Person(string n,int a) { Name = n;Age = a; }
        public string Name { set; get; }
        public int Age { set; get; }

        public void DisplayInfo() {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"{Age}");



        }

    }
}
