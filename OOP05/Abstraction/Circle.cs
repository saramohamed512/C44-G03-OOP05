using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstraction
{
    internal class Circle : Shape
    {
        public Circle(decimal R) { 
            Dim01 = Dim02 = R; // Assuming Dim01 is the radius
        }
        public override decimal Perimeter => 2*3.14m* Dim02;

        public override decimal CalcArea()
        {
            return 3.14m * Dim01 * Dim01; // Area of a circle is π * r^2, where r is the radius
        }
    }
}
