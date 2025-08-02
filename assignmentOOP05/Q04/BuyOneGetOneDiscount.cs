using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public class BuyOneGetOneDiscount : Discount
    {
        public override string Name => "Buy One Get One 50% Off";

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity < 2) return 0;
            return (price / 2) * (quantity / 2);
        }
    }
}
