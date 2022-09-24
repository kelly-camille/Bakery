// // Bread Tests
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bread.Models;

namespace Breadcalc.Models.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void CalcCost_outputCost_Number()
    {
      // Arrange

      //Act
      Order orderVariable = new Order();
      //Assert
      Assert.AreEqual(5, orderVariable.calcBCost(1));
    }
    [TestMethod]
    public void CalcCost_outputCost_10()
    {
      // Arrange

      //Act
      Order orderVariable = new Order();
      //Assert
      Assert.AreEqual(10, orderVariable.calcBCost(3));
    }
        [TestMethod]
    public void CalcCost_outputCost_30()
    {
      // Arrange

      //Act
      Order orderVariable = new Order();
      //Assert
      Assert.AreEqual(35, orderVariable.calcBCost(10));
    }
  }
}