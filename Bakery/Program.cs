using System;
using Bakery.Models;

namespace Bakery
{

  class Program
  {
  static void Main()
    {
      Bread testBread = Bread();
      Console.WriteLine(testBread.GetType());
    }
  }
}