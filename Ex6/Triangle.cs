using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    abstract class Triangle
    {
        public float A { get; set; }
        public float B { get; set; }
        public float angleAB { get; set; }

        public Triangle(float sideA, float sideB, float angle)
        {
            A = sideA;
            B = sideB;
            angleAB = angle;
        }

        public virtual float GetPerimeter()
        {
            float C = (float)Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(angleAB));
            return (float)Math.Round(A + B + C, 2);
        }

        public virtual float GetArea()
        {
            return (float)Math.Round(A * B * Math.Sin(angleAB) / 2, 2);
        }
    }
}
