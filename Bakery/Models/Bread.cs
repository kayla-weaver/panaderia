namespace Bakery.Models
{

  public class Bread
  {
    public int numBread;
    public int numFreeBread;
    // public int numBread {get; set;}
    // public int numFreeBread {get; set;}

    public Bread(int Quantity)
    {
      numBread = Quantity;
      numFreeBread = (numBread / 3 * 1);
    }

    public int GetNumBread()
    {
      return numBread;
    }
    public string CheckType()
    {
      return "Total Cost";
    }
  }
}