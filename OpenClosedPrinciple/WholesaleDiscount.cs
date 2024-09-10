using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class WholesaleDiscount : DiscountWithSolid
    {
        public override double ApplyDiscount(double value)
        {
            return value * 0.90;
        }
    }
}
