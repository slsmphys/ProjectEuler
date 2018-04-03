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
         long number = 2; //starting position (first prime number)
         long primeTarget = 2000000;
         long sum = 2;

         for (int x = 2; x < (primeTarget); x++)
         {
            if(isPrimeNumber(number))
            {
               sum += number;
            }
            number++;
         }
         Console.WriteLine("The sum of all the Primes upto {0} is: {1}", primeTarget, sum);
         Console.ReadKey();         
      }

      private static bool isPrimeNumber(long number)
      {
         for (int i = 2; i < (Math.Sqrt(number))+1; i++)
         {
            if(number % i == 0)
            {
               return false;
            }
         }
         return true;
      }
   }
}
