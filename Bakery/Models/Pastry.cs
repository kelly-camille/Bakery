// Business Pastries
using System;
using System.Collections.Generic;


namespace Pastry.Models
{
  public class PastryOrder
  {
    private int Quantity_p { get; set; }



    public int calcPCost(int quantity_p)
    {
     
      Quantity_p = quantity_p;
      int eachPrice = 2;
      int discountPrice = 1;

      if(quantity_p < 3)
      {
      int totalPrice = eachPrice * quantity_p;
      return totalPrice;
      }
      else if (quantity_p >= 3)
      {
      int discountItems = quantity_p / 3;
      int regPriceItems = quantity_p - discountItems;
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