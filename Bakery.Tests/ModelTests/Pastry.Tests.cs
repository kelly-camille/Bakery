// Pastry Tests

using Microsoft.VisualStudio.TestTools.UnitTesting;

using Pastry.Models;

namespace Pastry.Models.Tests
{
  [TestClass]
  public class PastryOrderTests
  {
    [TestMethod]
    public void CalcPCost_outputCost_4()
    {
      // Arrange

      //Act
      PastryOrder pastryOrderVariable = new PastryOrder();
      //Assert
      Assert.AreEqual(10, pastryOrderVariable.calcPCost(2));
    }
  }
}