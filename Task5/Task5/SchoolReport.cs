using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    sealed class SchoolReport
    {
        public string ReportTitle { set; get; }

        public SchoolReport(string t) {ReportTitle=t; }
        public void DisplayReportTitle() 
        {
            Console.WriteLine($"{ReportTitle}");
            Console.WriteLine("This is sealed class it means that the another classes can not inheart form this class (This class can not be parent)");

        }
    }
}
