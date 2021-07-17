using System;
using Bakery.TheBakery;


namespace Bakery
{
  class Program
  {
    static void Main()
    {
      RunBakery newBakery = new RunBakery(5, 2, 5);
      Console.WriteLine("Welcome to Pier's Bakery!");
      Console.WriteLine("Our Bread cost $" + newBakery._breadPrice + " but today its buy 2 get 1 free!");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      newBakery.breadNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Our pastries are $2 or 3 for $5");
      Console.WriteLine("How many pastries would you like to buy?");
      newBakery.pastryNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your total is: " + newBakery.customerCalculation());
    }
  }
}