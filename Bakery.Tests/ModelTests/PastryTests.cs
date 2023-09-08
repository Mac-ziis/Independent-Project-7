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
  }
}