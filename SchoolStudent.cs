using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1
{
    class SchoolStudent:Student
    {
        public int std;
        public string sec;

        public SchoolStudent(int roll, string name, int score, int std, string sec) : base(roll, name, score)
        {
            this.std = std;
            this.sec = sec;
        }

        public SchoolStudent():base()
        {

        }

        public override void SetData()
        {
            base.SetData();

            Console.Write("Enter Std: ");
            std = int.Parse(Console.ReadLine());

            Console.Write("Enter Sec: ");
            sec = Console.ReadLine();
        }

        public override void GetData()
        {
            base.GetData();

            Console.WriteLine("Standard: " + std);
            Console.WriteLine("Section: " + sec);
        }

        public override string ToString()
        {
            return base.ToString() + "\t" + std + "\t" + sec;
        }
    }
}
