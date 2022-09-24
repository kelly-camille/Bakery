// Business Pastries
using System;
using System.Collections.Generic;


namespace Pastry.Models
{
  public class PastryOrder
  {
    public int calcPCost(int pastriesUi)
    {
     
      int eachPrice = 2;
      // int numOfItemP = numOfItem;
      int discountPrice = 1;

      if(pastriesUi < 3)
      {
      int totalPrice = eachPrice * pastriesUi;
      return totalPrice;
      }
      else if (pastriesUi >= 3)
      {
      int discountItems = pastriesUi / 3;
      int regPriceItems = pastriesUi - discountItems;
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