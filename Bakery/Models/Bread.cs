namespace Bakery.Models
{

  public class Bread
  {
    public int numBread;
    public int numFreeBread;
    public int Bread1 {get; set;}
    public int Bread2 {get; set;}

    public Bread(int Quantity)
    {
      numBread = Quantity;
      numFreeBread = (numBread / 3 * 1);
    }
    public string CheckType()
    {
      return "Total Cost";
    }
  }
}