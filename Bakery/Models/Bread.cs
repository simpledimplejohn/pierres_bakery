using System;


namespace Bakery.TheBread
{
    public class Bread
    {        public double breadCalcPrice(double breadNumber, double breadPrice)
        {
            if (breadNumber <= 2)
            {
                return breadNumber * breadPrice;
            } else 
            {
                return ((breadNumber * breadPrice) - (Math.Floor(breadNumber / 3 ) * breadPrice));
            }
        }

    }
}
