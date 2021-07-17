using System;


namespace Bakery.ThePastry
{
    public class Pastry
    {
        private double pastryNumber { get; set; }

        public double pastryPrice()
        {
            return (Math.Floor(pastryNumber / 3) * 5) + ((pastryNumber % 3) * 2);
        }
    }
}
