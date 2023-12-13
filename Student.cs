using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1
{
    public class Student
    {
        public int roll;
        public string name;
        public int score;

        public Student()
        {
        }

        public Student(int roll, string name, int score)
        {
            this.roll = roll;
            this.name = name;
            this.score = score;
        }

        public virtual void SetData()
        {
            Console.Write("Enter Roll: ");
            roll = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Score: ");
            score = int.Parse(Console.ReadLine());
        }

        public virtual void GetData()
        {
            Console.WriteLine("Roll     : " + roll);
            Console.WriteLine("Name     : " + name);
            Console.WriteLine("Score    : " + score);
        }

        public override string ToString()
        {
            return $"{roll}\t{name}\t{score}";
        }
    }
}
