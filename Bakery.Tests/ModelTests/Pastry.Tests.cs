// Pastry Tests
using Pastry.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pastry.Models.Tests
{
    [TestClass]
    public class PastryOrderTests
    {
      [TestMethod]
      public void PastryConstructor_OutputOrder_Number()
      {
        PastryOrder newPastryOrder = new PastryOrder();

        Assert.AreEqual(typeof(PastryOrder), newPastryOrder.GetType());
      }
      
      [TestMethod]
      public void CalcPCost_outputCost_2()
      {
        PastryOrder pastryOrderVariable = new PastryOrder();
      
        Assert.AreEqual(2, pastryOrderVariable.calcPCost(1));
      }
      [TestMethod]
      public void CalcPCost_outputDiscountedCost_15()
      {
        // Arrange

        //Act
        PastryOrder pastryOrderVariable = new PastryOrder();
        //Assert
        Assert.AreEqual(15, pastryOrderVariable.calcPCost(9));
      }
    }
  }
