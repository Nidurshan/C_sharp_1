using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1
{
    class HrStudent:SchoolStudent
    {
        public string group;
        public HrStudent()
        {
        }

        public HrStudent(int roll, string name, int score, int std, string sec, string group) : base(roll, name, score, std, sec)
        {
            this.group = group;
        }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine("Group: " + group);
        }

        public override void SetData()
        {
            base.SetData();
            Console.Write("Enter Group: ");
            group = Console.ReadLine();
        }

        public override string ToString() 
        {
            return base.ToString() + "\t" + group;
        }
    }
}
