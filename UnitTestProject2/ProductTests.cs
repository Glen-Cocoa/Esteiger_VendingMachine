using System;
using System.Collections.Generic;
using Esteiger_VendingMachine.Resources.money;
using Esteiger_VendingMachine.Resources.products;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
  [TestClass]
  public class ProductTests
  {
    [TestMethod]
    public void VerifyProductCatalogue()
    {
      //Arrange
      var Catalogue = new ProductCatalogue();
      var Inventory = Catalogue.PopulateCatalogue();

      var InventoryList = new List<string>();
      List<string> ItemNames = new List<string>();
      //Act
      for (int i = 0; i < Inventory.Count; i++)
      {
        ItemNames.Add(Inventory[i].Name);
      }
      foreach (var entry in Catalogue.productInventory)
      {
        InventoryList.Add(entry.Key);
      }
      //Assert
      for (int i = 0; i < Inventory.Count; i++)
      {
        Assert.AreEqual(InventoryList[i], ItemNames[i]);
      }
    }
  }
}
