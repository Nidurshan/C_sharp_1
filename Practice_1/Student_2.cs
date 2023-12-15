using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1.Practice_1
{
    class Student_2:Person
    {
        public int standard;
        public string section;
        public string school;

        public Student_2() : base() 
        {
        }

        public override void SetData()
        {
            base.SetData();

            Console.Write("Enter Your Standard: ");
            standard = int.Parse(Console.ReadLine());

            Console.Write("Enter Your Section: ");
            section = Console.ReadLine();

            Console.Write("Enter Your School Name: ");
            school = Console.ReadLine();
        }

        public override void GetData()
        {
            base.GetData();

            Console.WriteLine("Standard: " + standard);
            Console.WriteLine("Section: " + section);
            Console.WriteLine("School: " + school);
        }
    }
}
