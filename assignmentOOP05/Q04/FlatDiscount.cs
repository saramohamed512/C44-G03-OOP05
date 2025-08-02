using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public class FlatDiscount : Discount
    {
        private readonly decimal _flatAmount;

        public FlatDiscount(decimal flatAmount)
        {
            _flatAmount = flatAmount;
        }

        public override string Name => $"${_flatAmount} Flat Discount";

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return _flatAmount * Math.Min(quantity, 1);
        }
    }
}
