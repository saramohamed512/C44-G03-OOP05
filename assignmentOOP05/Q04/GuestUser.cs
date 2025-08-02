using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public class GuestUser : User
    {
        public override string Name => "Guest User";

        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
