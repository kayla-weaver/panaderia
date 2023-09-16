using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry myPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), myPastry.GetType());
    }

    // [TestMethod]
    // public void BreadPrice_CalculatesCostOfBreadOrder_int()
    // {
    //   Bread myBread = new Bread(1);
    //   int price = myBread.BreadPrice();
    //   Assert.AreEqual(5, price);
    // }

    // [TestMethod]
    // public void BreadPrice_CalculatesCostOfBreadOrderForMoreThanOneBread_int()
    // {
    //   Bread myBread = new Bread(2);
    //   int price = myBread.BreadPrice();
    //   Assert.AreEqual(10, price);
    // }

    // [TestMethod]
    // public void BreadPrice_CalculatesCostOfBreadOrderForThreeBreads_int()
    // {
    //   Bread myBread = new Bread(3);
    //   int price = myBread.BreadPrice();
    //   Assert.AreEqual(10, price);
    // }

    // [TestMethod]
    // public void BreadPrice_CalculatesCostOfBreadOrderForSevenBreads_int()
    // {
    //   Bread myBread = new Bread(7);
    //   int price = myBread.BreadPrice();
    //   Assert.AreEqual(25, price);
    // }
  }


}