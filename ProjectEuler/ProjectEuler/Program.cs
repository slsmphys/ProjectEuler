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

         int sumOfSquares = 0;
         int sqrOfSums = 0;
         int difference = 0;

         for (int i = 1; i < 101; i++)
         {
            sumOfSquares += Convert.ToInt32(Math.Pow(i, 2));

            sqrOfSums += i;
         }

         sqrOfSums = Convert.ToInt32(Math.Pow(sqrOfSums, 2));

         difference = sqrOfSums - sumOfSquares;

         Console.WriteLine(difference.ToString());
         Console.Read();

      }
    }
}
