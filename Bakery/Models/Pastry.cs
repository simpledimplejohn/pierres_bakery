using System;


namespace Bakery.ThePastry
{
    public class Pastry
    {
        public double pastryNumber { get; set; }
        private double _pastryPrice = 3;
        private double _pastryDiscount = 5;

        public double pastryPrice {
            get {
                return _pastryPrice;
            }
        }
        public double pastryDiscount {
            get {
                return _pastryDiscount;
            }
        }

        public double pastryCalcPrice()
        {
            return (Math.Floor(pastryNumber / _pastryPrice) * _pastryDiscount) + ((pastryNumber % 3) * 2);
        }
    }
}
