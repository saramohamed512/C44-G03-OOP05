using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public class PremiumUser : User
    {
        public override string Name => "Premium User";

        public override Discount GetDiscount()
        {
            return new FlatDiscount(100);
        }
    }
}
