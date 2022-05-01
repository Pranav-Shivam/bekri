using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BekriShop
{
   public static class Class1
    {
       public static double TotalBill = 0.0;
       public static double TotalVar
       {
           get{ return TotalBill; }
           set { TotalBill = value; }
       }
    }
}
