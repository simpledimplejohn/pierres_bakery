using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.TheBread;
using Bakery.ThePastry;

namespace ToDoList.Tests
{
  [TestClass]  // used for test class
  public class ItemTests
  {

    [TestMethod]  // delcalre method as test method
    public void ItemConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    
  }
}