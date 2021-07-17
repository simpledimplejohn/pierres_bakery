using System;
using Bakery.TheBread;
using Bakery.ThePastry;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Bread newBread = new Bread();
      Pastry newPastry = new Pastry();
      Console.WriteLine("Welcome to Pier's Bakery!");
      Console.WriteLine("Our Bread cost $" + newBread.bread + " but today its buy 2 get 1 free!");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      newBread.breadNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Our pastries are $2 or 3 for $5");
      Console.WriteLine("How many pastries would you like to buy?");
      newPastry.pastryNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Your total is $" + (newBread.breadPrice() + newPastry.pastryPrice()));
    }
  }
}