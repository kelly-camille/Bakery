// Business Pastries
using System;
using System.Collections.Generic;


namespace Pastry.Models
{
  public class PastryOrder
  {
    public int calcPCost(int ui)
    {
      int unusedVar = ui;
      int eachPrice = 2;
      int numOfItem = 9;
      int discountPrice = 1;

      if(numOfItem < 3)
      {
      int totalPrice = eachPrice * numOfItem;
      return totalPrice;
      }
      else if (numOfItem >= 3)
      {
      int discountItems = numOfItem / 3;
      int regPriceItems = numOfItem - discountItems;
      int discount = discountItems * discountPrice;
      int regPrice = regPriceItems * eachPrice;
      int final = discount + regPrice;
      return final;
      }
      else
      {
      return 0;
      }
    }
  }
}