using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstraction
{
    internal abstract class BaseArea:Shape
    {
        

        public override decimal CalcArea()
        {
            return Dim01 * Dim02; // Assuming Dim01 and Dim02 are the base dimensions
        }
    }
   
}
