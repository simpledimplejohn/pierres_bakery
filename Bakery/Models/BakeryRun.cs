using System;
using Bakery.ThePastry;
using Bakery.TheBread;

namespace Bakery.TheBakery
{
  public class RunBakery
  {
    Bread newBread = new Bread();
    Pastry newPastry = new Pastry();
    public double customerPrice { get; set; }
    public void customerCalculation() 
    {
      customerPrice = newBread.breadCalcPrice() + newPastry.pastryCalcPrice();
    }
  }
}