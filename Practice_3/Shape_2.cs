﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1.Practice_3
{
    internal class Shape_2
    {
        public virtual int Length { get; set; } = 0;
        public virtual int Width { get; set; } = 0;

        public Shape_2()
        {
        }

        public virtual void SetValues()
        {
            Console.Write("Enter Length: ");
            Length = int.Parse(Console.ReadLine());

            Console.Write("Enter Width: ");
            Width = int.Parse(Console.ReadLine());
        }

        public virtual void Find_Area() 
        {
        }
    }
}