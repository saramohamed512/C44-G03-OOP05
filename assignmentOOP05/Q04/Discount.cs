using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public abstract class Discount
    {
        public abstract string Name { get; }
        public abstract decimal CalculateDiscount(decimal price, int quantity);
    }
}
