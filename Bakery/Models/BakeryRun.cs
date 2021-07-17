using System;
using Bakery.ThePastry;
using Bakery.TheBread;

namespace Bakery.TheBakery
{
  public class RunBakery
  {
    Bread newBread = new Bread();
    Pastry newPastry = new Pastry();
    public double _breadPrice { get; }
    public double _pastryPrice { get; }
    public double _pastryDiscount { get; }
    public double breadNumber { get; set; }
    public double pastryNumber { get; set; }

    public RunBakery(double breadPrice, double pastryPrice, double pastryDiscount)
    {
      _breadPrice = breadPrice;
      _pastryPrice = pastryPrice;
      _pastryDiscount = pastryDiscount;
    }
    public double customerCalculation() 
    {
      return 
      newBread.breadCalcPrice(breadNumber, _breadPrice) +
      newPastry.pastryCalcPrice(pastryNumber, _pastryPrice, _pastryDiscount);
    }
  }
}