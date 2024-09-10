using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    public class DiscountWithoutSolid
    {
       public double ApplyDiscount(double value)
       {
            if (value > 100)
                return value * 0.90; 

            return value * 0.95; 
       }
    }
}
