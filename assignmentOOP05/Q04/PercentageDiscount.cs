using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignmentOOP05.Q04
{
    public class PercentageDiscount : Discount
    {
        private readonly decimal _percentage;

        public PercentageDiscount(decimal percentage)
        {
            _percentage = percentage;
        }

        public override string Name => $"{_percentage}% Discount";

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return price * quantity * (_percentage / 100);
        }
    }
}
