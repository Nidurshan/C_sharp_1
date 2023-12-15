using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_1.Practice_3
{
    internal class Rectrangle_2 : Shape_2
    {
        public int RectrangleArea;

        public Rectrangle_2()
        {
        }

        public override int Length { get => base.Length; set => base.Length = value; }
        public override int Width { get => base.Width; set => base.Width = value; }

        public override void SetValues()
        {
            base.SetValues();
        }

        public override void Find_Area()
        {
            base.Find_Area();

            RectrangleArea = Length * Width;
            Console.WriteLine("Rectrangle Area: " + RectrangleArea);
        }
    }
}
