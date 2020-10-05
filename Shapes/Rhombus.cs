using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Rhombus : Shape
    {
        public float Side { get; set; }
        public Rhombus(float side)
        {
            Side = side;
        }

        public override float GetPerimeter()
        {
            return (float)Math.Round(Side * 4, 2);
        }
        public override float GetArea()
        {
            return (float)Math.Round(Side * Side, 2);
        }
    }
}
