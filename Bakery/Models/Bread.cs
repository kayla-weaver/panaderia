namespace Bakery.Models
{

  public class Bread
  {
  public int numBread = 10;
  public int numFreeBread = numBread / 3 * 1;
  public int totalCost = (numBread - numFreeBread) * 5;
  Console.WriteLine("Total cost: $" +totalCost);
  }
}