using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
  static void Main()
    {

      Console.WriteLine("How many loaves of bread would you like?");
      int userNumberOfLoaves = int.Parse(Console.ReadLine());
      Console.WriteLine("How many pastries would you like?");
      int userNumberOfpastries = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(userNumberOfLoaves);
      int breadCost = userBread.BreadPrice();
      Pastry userPastry = new Pastry(userNumberOfpastries);
      int pastryCost = userPastry.PastryPrice();
      int totalCost = breadCost + pastryCost;
      Console.WriteLine($"Cost for your yummy goodies: ${totalCost}");

    }
  }
}