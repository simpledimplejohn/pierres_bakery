using System;


namespace Bakery.TheBread
{
    public class Bread
    {
        public int breadNumber { get; set; }

        private int _breadPrice = 5;
        public void Test() 
        {
            Console.WriteLine("Bread Class Works!");

        }
        public int breadPrice {
            get {
                return _breadPrice;
            }
        }
    }
}
