// Pastry Tests

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pastry.Models;

namespace Pastry.Models.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void CalcPCost_outputCost_15()
    {
      // Arrange

      //Act
      PastryOrder pastryOrderVariable = new PastryOrder();
      //Assert
      Assert.AreEqual(15, pastryOrderVariable.calcPCost(9));
    }
  }
}