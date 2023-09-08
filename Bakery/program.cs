using System;
using Bakery.Models;

namespace PierreBakery
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread: $5 each or Buy 2, get 1 free!");
      Console.WriteLine("Pastry: $2 each or Buy 3, get 1 free!");

      Console.Write("How many loaves of Bread would you like to buy? ");
      int breadQuantity = int.Parse(Console.ReadLine());
    }
  }
}
