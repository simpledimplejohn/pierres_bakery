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
      newBread.Test();
      newPastry.Test();
      Console.WriteLine("Welcome to Pier's Bakery!");
      Console.WriteLine("We have Bread and Pastries");
      Console.WriteLine("Our Bread cost " + 5 + " dollars");
      Console.WriteLine("Our Pastries cost " + 2 + " dollars");
      Console.WriteLine("How many loaves of bread would you like to buy?");
      int breadNumber = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("You want " + breadNumber + " loaves of bread");

    }
  }
}