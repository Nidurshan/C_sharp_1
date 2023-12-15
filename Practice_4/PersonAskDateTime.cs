using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1.Practice_4
{
    internal class PersonAskDateTime:PrintDateTime
    {
        public PersonAskDateTime() 
        {
        }

        public void Question()
        {
            Console.WriteLine("What is the Time?");
        }

        public override void PrintCurrentDateTime()
        {
            base.PrintCurrentDateTime();

            Console.WriteLine("The Current time is " + );
        }
    }
}
