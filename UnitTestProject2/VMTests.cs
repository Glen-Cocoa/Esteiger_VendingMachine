using System;
using System.Collections.Generic;
using Esteiger_VendingMachine.Resources.money;
using Esteiger_VendingMachine;
using Esteiger_VendingMachine.Resources.products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
  [TestClass]
  public class VMTests
  {
    [TestMethod]
    public void VerifyLessThanTwo()
    {
      //Arrange
      VendingMachine vending = new VendingMachine();
      List<IProduct> ReducedList = vending.ReturnInventoryLessThanTwo();
      List<int> prices = new List<int>();
      //Act
      foreach (var product in ReducedList)
      {
        prices.Add(product.Value);
      }
      //Assert

      for (int i = 0; i < prices.Count; i++)
      {
        Assert.IsTrue(prices[i] < 200);
      }
    }
  }
}
