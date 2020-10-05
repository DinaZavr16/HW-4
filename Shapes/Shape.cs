using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
  abstract class Shape
    {
        public virtual float GetPerimeter() { return 0; }
        public virtual float GetArea() { return 0; }
    }
}
