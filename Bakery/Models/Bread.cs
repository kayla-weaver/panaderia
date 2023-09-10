namespace Bakery.Models
{

  public class Bread
  {
    public int numBread;
    public int numFreeBread;
    public int Bread1 {get; set;}
    public int Bread2 {get; set;}
    testBread.Bread1 = 5;
    testBread.bread2 = 10;

    public Bread(int quantity, int numFreeBread)
    {
      numBread = quantity;
      numFreeBread = numBread / 3 * 1;
    }
    public string CheckType()
    {
      return "Total Cost";
    }
  // public int numBread = 10;
  // public int numFreeBread = numBread / 3 * 1;
  // public int totalCost = (numBread - numFreeBread ) * 5;
  // Console.WriteLine("Total cost: $" +totalCost);
  }
}