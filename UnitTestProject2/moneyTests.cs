using System;
using Esteiger_VendingMachine.Resources.money;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
  [TestClass]
  public class MoneyTests
  {
    [TestMethod]
    public void CheckDollar()
    {
      //arrange
      Currency dollar = new Dollar();
      //act
      float Val = dollar.Value;
      //assert
      Assert.AreEqual(100, Val);
    }
    [TestMethod]
    public void CheckQuarter()
    {
      //arrange
      Currency quarter = new Quarter();
      //act
      float Val = quarter.Value;
      //assert
      Assert.AreEqual(25, Val, 0.01);
    }
    [TestMethod]
    public void CheckDime()
    {
      //arrange
      Currency dime = new Dime();
      //act
      float Val = dime.Value;
      //assert
      Assert.AreEqual(10, Val, 0.01);
    }
    [TestMethod]
    public void CheckNickel()
    {
      //arrange
      Currency nickel = new Nickel();
      //act
      float Val = nickel.Value;
      //assert
      Assert.AreEqual(5, Val, 0.01);
    }
  }
}
