namespace Bakery.Models
{

  public class Bread
  {
    public int numBread;
    public int numFreeBread;

    public Bread(totalCost)
    {
      totalCost = (numBread- numFreeBread) *5;
    }
    public string CheckType()
    {
      return "We will see?";
    }
  // public int numBread = 10;
  // public int numFreeBread = numBread / 3 * 1;
  // public int totalCost = (numBread - numFreeBread ) * 5;
  // Console.WriteLine("Total cost: $" +totalCost);
  // }
}