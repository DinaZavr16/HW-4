using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Triangle : Shape
    {
        public float A { get; set; }
        public float B { get; set; }
        public float C { get; set; }

        public Triangle(float sideA, float sideB, float sideC)
        {
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ArgumentException("This is not triangle!");
            }

            A = sideA;
            B = sideB;
            C = sideC;
        }

        public override float GetPerimeter()
        {
            return (float)Math.Round(A + B + C, 2);
        }

        public override float GetArea()
        {
            float p = this.GetPerimeter() / 2;
            return (float)Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 2);
        }
    }
}
