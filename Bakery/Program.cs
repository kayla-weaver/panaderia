using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
  static void Main()
    {
      Console.WriteLine("Welcome to my all Vegan bakery! We have a special on bread and pastries today. Bread is $5 for one loaf and every three loaves are free! Pasties are $2 each and every fourth pastry is free. The more you buy, the more you save!");
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