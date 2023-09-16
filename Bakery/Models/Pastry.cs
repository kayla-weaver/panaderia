namespace Bakery.Models
{

  public class Pastry
  {
    public int numPastry {get; set;}
    public int numFreePastry {get; set;}

    public Pastry(int Quantity)
    {
      numPastry = Quantity;
      numFreePastry = (numPastry / 4 * 1);
    }

    public int PastryPrice()
    {
      int totalCost = (2 * numPastry) - (2 * numFreePastry);
      return totalCost;
    }
  }
}