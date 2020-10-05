using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_HW
{
    class Triangle
    {
        public float A, B, C;
        public Triangle(float a, float b, float c)
        {
            A = a;
            B = b;
            C = c;
        }
        
        public List<double> Angle()
        {
            double cosA = (B * B + C * C - A * A) / (2 * B * C);
            double cosB = (A * A + C * C - B * B) / (2 * A * C);
            double cosC = (A * A + B * B - C * C) / (2 * A * B);

            double angleA = Math.Round(Math.Acos(cosA) * 180 / Math.PI, 2);
            double angleB = Math.Round(Math.Acos(cosB) * 180 / Math.PI, 2);
            double angleC = Math.Round(Math.Acos(cosC) * 180 / Math.PI, 2);

            return new List<double> { angleA, angleB, angleC };
        }
        public float Perymetr()
        {
            return A + B + C;
        }
    }
}
