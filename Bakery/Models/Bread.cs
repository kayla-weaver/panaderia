namespace Bakery.Models
{

  public class Bread
  {
    // public int numBread;
    // public int numFreeBread;
    public int numBread {get; set;}
    public int numFreeBread {get; set;}

    public Bread(int Quantity)
    {
      numBread = Quantity;
      numFreeBread = (numBread / 3 * 1);
    }

    public int BreadPrice()
    {
      int totalCost = (5 * numBread) - (5 * numFreeBread);
      return totalCost;
    }
  }
}