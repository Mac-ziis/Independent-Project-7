using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void Pastry_CalculateCost()
    {
      PastryOrder pastryOrder = new PastryOrder(5);
      decimal cost = pastryOrder.CalculatePastryCost();

      Assert.AreEqual(8.0m, cost);
    }
    // Shows the reduction after deals
    [TestMethod]
    public void Pastry_CalculateReducedCost()
    {
      PastryOrder pastryOrder = new PastryOrder(6);
      decimal cost = pastryOrder.CalculatePastryCost();

      Assert.AreEqual(10.0m, cost);
    }
  }
}