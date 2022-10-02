// Business Bread
using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class Order
  {
    public int Quantity_b { get; set; }

    public int calcBCost(int quantity_b)
    {

      Quantity_b = quantity_b;
      int eachPrice = 5;

      if(quantity_b < 3)
      {
      int totalPrice = eachPrice * quantity_b;
      return totalPrice;
      }
      else if (quantity_b >= 3)
      {
      int freeItems = quantity_b / 3; //round down
      int regPriceItems = quantity_b - freeItems;
      int discount = freeItems * eachPrice;
      int totalDiscountPrice = regPriceItems * eachPrice;
      return totalDiscountPrice;
      }
      else
      {
      return 0;
      }
    }
  }
}

