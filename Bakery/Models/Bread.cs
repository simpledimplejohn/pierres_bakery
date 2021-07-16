using System;


namespace Bakery.TheBread
{
    public class Bread
    {
        public double breadNumber { get; set; }

        private double _bread = 5;
        public void Test() 
        {
            Console.WriteLine("Bread Class Works!");

        }
        public double bread {
            get {
                return _bread;
            }
        }

        public double breadPrice()
        {
            if (breadNumber <= 2)
            {
                return breadNumber * _bread;
            } else 
            {
                Console.WriteLine("your discounted price is: ");
                return ((breadNumber % 3) * _bread) - 5;
            }
        }

    }
}
