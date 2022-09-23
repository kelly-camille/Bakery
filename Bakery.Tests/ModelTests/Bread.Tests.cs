// Bread Tests
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Bread.Models;

namespace Bread.Models.Tests
{
  [TestClass]
  public class BreadCostTest
  {
    [TestMethod]
    public void CalcCost_outputCost_Number()
    {
      Order orderVariable = new Order();
      Assert.AreEqual("5", orderVariable.calcCost("bread"));
    }
  }
}



//b - calculates cost of bread based on given number
// - calculates cost of pastry based on given number
//returns - total cost of the order 


//BREAD COST = $5 each, 
//if bread# = 1,
// charge $5
// else if bread# = 2
// charge $10
// else if 
// bread# = 3
// charge $10
// else
// "order is limited to 3 per person"


// Ui - User input - number of loafs of bread and loafs of pastry they would like

