using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP05.Abstraction
{
    internal class Rectangle : BaseArea
    {
        public override decimal Perimeter => (Dim01+Dim02)*2;
    
    }

}
