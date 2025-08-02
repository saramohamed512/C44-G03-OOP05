using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstraction
{
    internal class Square: BaseArea
    {
        public Square(decimal sideLength)
        {
            Dim01= Dim02 = sideLength;
          
        }
        public override decimal Perimeter => Dim01 * 4; // Perimeter of a square is 4 times the side length
                                                        // No need to override CalcArea as it is already defined in BaseArea

    }

}
