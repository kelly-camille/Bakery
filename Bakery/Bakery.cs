//UI
using System;
using System.Collections.Generic;
using Bread.Models;
using Pastry.Models;

namespace Bakery
{
	public class Program
	{
		public static void Main()
    {
      Console.WriteLine("Welcome to my Bakery. Loaves of bread cost $5 each. If you buy two  we'll give you a third loaf for free. Pastries are $2. If you buy two pastries, we'll give you the third for a dollar!");
      Console.WriteLine("How many loaves of bread would you like to order?");
      string quantity_b = Console.ReadLine();
      int numOfItemB = Int32.Parse(quantity_b);

      Console.WriteLine("How many pastries would you like to order?");
      string quantity_p = Console.ReadLine();
      int numOfItemP = Int32.Parse(quantity_p);

      Order orderVariable = new Order();
      PastryOrder pastryOrderVariable = new PastryOrder();

      int breadCost = orderVariable.calcBCost(numOfItemB);
      int pastryCost =  pastryOrderVariable.calcPCost(numOfItemP);
   
      int finalCost = breadCost + pastryCost;

      Console.WriteLine("Your total is $" + finalCost);
      Console.WriteLine("Thank you for stopping buy. Have a wonderful day!");

      
    }
  }
}
 