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
    public void Pastry_CalculateCost()
    {
      BreadOrder breadOrder = new BreadOrder();
      decimal pastryCost = breadOrder.CalculatePastryCost(5);

      Assert.AreEqual(9.0m, breadOrder);
    }
  }
}