using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_HW
{
    class EquilTriangle : Triangle
    {
        private float area;

        public EquilTriangle(float a, float b, float c) : base(a, b, c)
        {
            area = (float)Math.Round((float)(Math.Sqrt(3) * A * A / 4), 2);
        }
        public float GetArea()
        {
            return area;
        }
    }
}
