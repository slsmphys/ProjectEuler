using System;

namespace ProjectEuler
{
   class Program
    {
      static void Main(string[] args)
      {
         //determine value of 76576500 by brute force
         int factors = 0;
         long n = 1;
         long sum = 0;

         do
         {
            sum = 0;
            factors = 0;
            //establish the triangle
            for (int i = 1; i < (n + 1); i++)
            {
               sum += i;
            }
            //determine number of factors;
            for (int i = 1; i < sum + 1; i++)
            {
               if (sum % i == 0)
               {
                  //factor found
                  factors++;
               }
            }
            Console.WriteLine(sum.ToString());
            n++;
         } while (factors < 500);

         Console.WriteLine("{0},   has {1} factors", sum, factors);
         Console.ReadKey();
      }
   }
}
