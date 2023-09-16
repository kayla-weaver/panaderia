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

    [TestMethod]
    public void PastryPrice_CalculatesCostOfPastryOrder_int()
    {
      Pastry myPastry = new Pastry(1);
      int price = myPastry.PastryPrice();
      Assert.AreEqual(2, price);
    }

    [TestMethod]
    public void PastryPrice_CalculatesCostOfPastryOrderForMoreThanOnePastry_int()
    {
      Pastry myPastry = new Pastry(2);
      int price = myPastry.PastryPrice();
      Assert.AreEqual(4, price);
    }

    [TestMethod]
    public void PastryPrice_CalculatesCostOfPastryOrderForFourPastry_int()
    {
      Pastry myPastry = new Pastry(4);
      int price = myPastry.PastryPrice();
      Assert.AreEqual(6, price);
    }

    [TestMethod]
    public void PastryPrice_CalculatesCostOfPastryOrderForSevenPastry_int()
    {
      Pastry myPastry = new Pastry(7);
      int price = myPastry.PastryPrice();
      Assert.AreEqual(12, price);
    }
  }


}