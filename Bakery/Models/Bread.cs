using System;


namespace Bakery.TheBread
{
    public class Bread
    {
        public int breadNumber { get; set; }

        private int _bread = 5;
        public void Test() 
        {
            Console.WriteLine("Bread Class Works!");

        }
        public int bread {
            get {
                return _bread;
            }
        }

        public int breadPrice()
        {
            if (breadNumber == 1)
            {
                return 5;
            } else 
            {
                Console.WriteLine("TODAY ONLY! 2 for 1");
                return breadNumber * 2;
            }
        }

    }
}
