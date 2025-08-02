using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public abstract class User
    {
        public abstract string Name { get; }
        public abstract Discount GetDiscount();
    }
}
