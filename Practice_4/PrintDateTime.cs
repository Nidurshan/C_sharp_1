using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1.Practice_4
{
    internal class PrintDateTime
    {

        public PrintDateTime() 
        {
        }

        public virtual void PrintCurrentDateTime()
        {
            DateTime currentDateTime = DateTime.Now;

            Console.WriteLine("Current Date and Time: " + currentDateTime.ToString("yyyy-MM-dd / HH:mm:ss"));

            Console.WriteLine("Short Date: " + currentDateTime.ToShortDateString());
            Console.WriteLine("Long Date: " + currentDateTime.ToLongDateString());
            Console.WriteLine("Short Time: " + currentDateTime.ToShortTimeString());
            Console.WriteLine("Long Time: " + currentDateTime.ToLongTimeString());

            Console.WriteLine("Default Format: " + currentDateTime);
        }
    }
}