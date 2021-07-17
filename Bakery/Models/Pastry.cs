using System;


namespace Bakery.ThePastry
{
    public class Pastry
    {
        public double pastryCalcPrice(double pastryNumber, double pastryPrice, double pastryDiscount)
        {
            return (Math.Floor(pastryNumber / 3) * pastryDiscount) + ((pastryNumber % 3) * pastryPrice);
        }
    }
}
