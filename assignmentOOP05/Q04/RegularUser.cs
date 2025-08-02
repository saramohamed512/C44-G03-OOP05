using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public class RegularUser : User
    {
        public override string Name => "Regular User";

        public override Discount GetDiscount()
        {
            return new PercentageDiscount(5);
        }
    }
}
