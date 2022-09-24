// Business Bread

using System;
using System.Collections.Generic;

namespace Bread.Models
{
  public class Order
  {
    public int calcBCost(int breadUi)
    {
   
      int eachPrice = 5;
      // int numOfItemP = numOfItem;

      if(breadUi < 3)
      {
      int totalPrice = eachPrice * breadUi;
      return totalPrice;
      }
      else if (breadUi >= 3)
      {
      int freeItems = breadUi / 3; //round down
      int regPriceItems = breadUi - freeItems;
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


//     public int calcBCost(int breadUi)
//     {
   
//       int eachPrice = 5;
//       int numOfItemP = numOfItem;

//       if(numOfItem < 3)
//       {
//       int totalPrice = eachPrice * numOfItem;
//       return totalPrice;
//       }
//       else if (numOfItem >= 3)
//       {
//       int freeItems = numOfItem / 3; //round down
//       int regPriceItems = numOfItem - freeItems;
//       int discount = freeItems * eachPrice;
//       int totalDiscountPrice = regPriceItems * eachPrice;
//       return totalDiscountPrice;
//       }
//       else
//       {
//       return 0;
//       }
//     }
//   }
// }