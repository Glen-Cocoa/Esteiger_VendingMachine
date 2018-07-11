using System;
using Esteiger_VendingMachine.Resources.money;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
  [TestClass]
  public class VendingMachineTests
  {
    [TestMethod]
    public void CheckDollar()
    {
      //arrange
      var dollar = new Dollar();
      //act
      float Val = dollar.GetValue();
      //assert
      Assert.AreEqual(1, Val);
    }
    [TestMethod]
    public void CheckQuarter()
    {
      //arrange
      var quarter = new Quarter();
      //act
      float Val = quarter.GetValue();
      //assert
      Assert.AreEqual(0.25, Val, 0.01);
    }
    [TestMethod]
    public void CheckDime()
    {
      //arrange
      var dime = new Dime();
      //act
      float Val = dime.GetValue();
      //assert
      Assert.AreEqual(0.10, Val, 0.01);
    }
    [TestMethod]
    public void CheckNickel()
    {
      //arrange
      var nickel = new Nickel();
      //act
      float Val = nickel.GetValue();
      //assert
      Assert.AreEqual(0.05, Val, 0.01);
    }
  }
}
