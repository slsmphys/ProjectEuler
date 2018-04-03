using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
   class Program
   {
      static void Main(string[] args)
      {
         for (int a = 1; a < 1000; a++)
         {
            for (int b = 2; b < 1000; b++)
            {
               if(500000 - 1000*(a+b) + (a*b) == 0 && a < b)
               {
                  var c = (1000 - a - b);
                  Console.WriteLine("a = {0} and b = {1} and c = {2}", a, b, c);
                  var product = (Int64)(a * b * c);
                  Console.WriteLine("The product abc = {0}", product);
               }
            }
         }
         Console.ReadKey();
      }
   }
}
