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
    }
  }
}