using System;
using Bakery.Models;

namespace Bakery
{

  class Program
  {
  static void Main()
    {
      Bread testBread = new Bread(9,3);
      Console.WriteLine($"You asked for: {testBread.numBread} loaves of bread");
      Console.WriteLine("Calculating your total...");
      Console.WriteLine($"Your total today will be: {testBread.NumFreeBread} we hope you enjoy your breads!");
    }
  }
}