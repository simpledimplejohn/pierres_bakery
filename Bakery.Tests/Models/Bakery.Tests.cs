using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.TheBread;
using Bakery.ThePastry;
using Bakery.TheBakery;

namespace Bakery.Tests
{
  [TestClass]  // used for test class
  public class BakeryTests
  {

    [TestMethod]  // declared method as test method
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void BakeryConstructor_CreateInstanceOfBakery_Bakery()
    {
      RunBakery newBakery = new RunBakery(5, 2, 5);
      Assert.AreEqual(typeof(RunBakery), newBakery.GetType());

    }

    [TestMethod]
    public void DoesBread_CalculatePriceForZero()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(0, newBread.breadCalcPrice(0, 5));
    }

    [TestMethod]
    public void DoesBread_CalculatePriceForOne()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(5, newBread.breadCalcPrice(1, 5));
    }

    [TestMethod]
    public void DoesBread_CalculatePriceForTwo()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.breadCalcPrice(2, 5));
    }

    [TestMethod]
    public void DoesBread_CalculatePriceForThree()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(10, newBread.breadCalcPrice(3, 5));
    }

    [TestMethod]
    public void DoesBread_CalculatePriceForTwelveLoaves()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(40, newBread.breadCalcPrice(12, 5));
    }

    [TestMethod]
    public void DoesPastry_CalculatePriceForZero()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(0, newPastry.pastryCalcPrice(0, 2, 5));
    }

    [TestMethod]
    public void DoesPastry_CalculatePriceForOne()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(2, newPastry.pastryCalcPrice(1, 2, 5));
    }
  }
}