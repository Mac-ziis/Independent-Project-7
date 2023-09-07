namespace Bakery.Models
{
  public class BreadOrder
  {
    public int Quantity { get; set; }

    public BreadOrder(int quantity)
    {
      Quantity = quantity;
    }

    public decimal CalculateBreadCost()
    {
      int breadDealCount = Quantity / 3;
      int breadRegularCount = Quantity % 3;

      decimal breadCost = (breadDealCount * 2 + breadRegularCount) * 5.0m;

      return breadCost; 
    }
  }
}