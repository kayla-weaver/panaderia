using System;
using Bakery.Models;

namespace Bakery
{

  class Program
  {
  static void Main()
    {
      Bread testBread = new Bread(10,0);
      Console.WriteLine(testBread.GetType());
      testBread.Bread1 = 5;
      testBread.Bread2 = 10;
      Console.WriteLine($"One bread costs: {testBread.Bread1}");
      Console.WriteLine($"Two bread costs: {testBread.Bread2}");
    }
  }
}