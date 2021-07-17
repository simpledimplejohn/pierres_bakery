using System;
using Bakery.ThePastry;
using Bakery.TheBread;

namespace Bakery.TheBakery
{
  public class RunBakery
  {
    Bread newBread = new Bread();
    Pastry newPastry = new Pastry();
    private double BreadPrice = 5;
    private double PastryPrice = 2;
    private double PastryDiscount = 5;
    public double BreadNumber { get; set; }
    public double PastryNumber { get; set; }

    public double customerPrice { get; set; }
    public void customerCalculation() 
    {
      customerPrice = 
      newBread.breadCalcPrice(BreadNumber, BreadPrice) + 
      newPastry.pastryCalcPrice(PastryNumber, PastryPrice, PastryDiscount);
    }
  }
}