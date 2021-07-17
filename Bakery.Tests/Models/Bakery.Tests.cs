using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.TheBread;
using Bakery.ThePastry;
using Bakery.TheBakery;

namespace ToDoList.Tests
{
  [TestClass]  // used for test class
  public class ItemTests
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
  }
}