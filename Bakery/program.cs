using System;
using Bakery.Models;
using Bakery.UserInterfaceModels;

namespace PierreBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine(WelcomeBanner.Welcome);

      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread: $5 each or Buy 2, get 1 free!");
      Console.WriteLine("Pastry: $2 each or Buy 3, get 1 free!");

      Console.Write("How many loaves of Bread would you like to buy? ");
      int breadQuantity = int.Parse(Console.ReadLine());

      Console.Write("How many Pastries would you like to buy? ");
      int pastryQuantity = int.Parse(Console.ReadLine());

      BreadOrder breadOrder = new BreadOrder(breadQuantity);
      PastryOrder pastryOrder = new PastryOrder(pastryQuantity);

      decimal totalCost = breadOrder.CalculateBreadCost() + pastryOrder.CalculatePastryCost();

      Console.WriteLine("Thank you for your order!");
      Console.WriteLine($"Here is the total cost for your items: ${totalCost}0");
      Console.WriteLine(GoodbyeBanner.Goodbye);
      Console.WriteLine("Have a lovely day!");
    }
  }
}
