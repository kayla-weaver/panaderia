namespace Bakery.Models
{

  public class Bread
  {
    public int numBread;
    public int numFreeBread;
    public int Bread1 {get; set;}
    public int Bread2 {get; set;}

    public Bread(int Quantity, int numFreeBread)
    {
      numBread = Quantity;
      numBread / 3 * 1 = numFreeBread;
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