// // Bread Tests
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bread.Models;

namespace Breadcalc.Models.Tests
{
  [TestClass]
  public class BreadTest
  {
    [TestMethod]
    public void OrderConstructor_OutputOrder_Number()
    {
     Order newOrder = new Order();

     Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void CalcCost_outputCost_Number()
    {
      Order orderVariable = new Order();
      
      Assert.AreEqual(5, orderVariable.calcBCost(1));
    }
    [TestMethod]
    public void CalcCost_outputDiscountedCost_10()
    {
     
      Order orderVariable = new Order();
      
      Assert.AreEqual(10, orderVariable.calcBCost(3));
    }
        [TestMethod]
    public void CalcCost_outputCost_35()
    {
     
    
      Order orderVariable = new Order();
     
      Assert.AreEqual(35, orderVariable.calcBCost(10));
    }
  }
}