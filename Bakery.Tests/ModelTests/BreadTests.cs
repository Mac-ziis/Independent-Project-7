using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void Bread_CalculateCost()
    {
      BreadOrder breadOrder = new BreadOrder(2);
      decimal cost = breadOrder.CalculateBreadCost();

      Assert.AreEqual(10.0m, cost);
    }
    // After purchasing 3 the fourth is reduced
    [TestMethod]
    public void Bread_CalculateReducedCost()
    {
      BreadOrder breadOrder = new BreadOrder(4);
      decimal cost = breadOrder.CalculateBreadCost();

      Assert.AreEqual(15.0m, cost);
    }
  }
}