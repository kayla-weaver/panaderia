using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
  static void Main()
    {
      Bread testBread = new Bread(9);
      Console.WriteLine($"You asked for: {testBread.GetNumBread()} loaves of bread");
      Console.WriteLine("Calculating how many free loaves...");
      Console.WriteLine($"Today you will recieve {testBread.numFreeBread} loaves of bread for free!");
      Console.WriteLine("Calculating cost....");
      Console.WriteLine($"Your total is {(testBread.GetNumBread()-testBread.numFreeBread)* 5} dollars");
    }
  }
}