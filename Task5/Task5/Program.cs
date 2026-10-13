using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
     class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Omar",22);
            //p._internalCode = "Code"; //This Field can not be access in other calsses because it have a private Access Modifier
            Student s1 = new Student("Ali",20,"Orange Manger");
            Student s2 = new Student("Alaa", 20, "Orange trainer");
            Teachercs t1 = new Teachercs("Mohammad",35,"Math");
            s1.DisplayStuInfo();
            s2.DisplayStuInfo();
            SchoolReport sr = new SchoolReport("Report");
            sr.DisplayReportTitle();

        }
    }
}
