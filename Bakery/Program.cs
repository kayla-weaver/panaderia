using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
  static void Main()
    {

      Console.WriteLine("How many loaves you want?");
      int userNumberOfLoaves = int.Parse(Console.ReadLine());
      Bread userBread = new Bread(userNumberOfLoaves);
      int breadCost = userBread.BreadPrice();
      Console.WriteLine($"Cost for bread: ${breadCost}");

      // int totalCost = breadCost + pastryCost;
    }
  }
}