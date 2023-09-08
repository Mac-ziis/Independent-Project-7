namespace Bakery.Models
{
  public class PastryOrder
  {
    public int Quantity { get; set; }
    
    public PastryOrder(int quantity)
    {
      Quantity = quantity;
    }

    public decimal CalculatePastryCost()
    {
      int pastryDealCount = Quantity / 4;
      int pastryRegularCount = Quantity % 4;

      decimal pastryCost = (pastryDealCount * 3 + pastryRegularCount) * 2.0m;

      return pastryCost;
    }
  }
}