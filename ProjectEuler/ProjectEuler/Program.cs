using System;
using System.Collections;

namespace ProjectEuler
{
   class Program
   {

      public static ArrayList primeNumbers = new ArrayList();
      static void Main(string[] args)
      {
         var number = 2;
         var counter = 0;
         var primeTarget = 10001;

         while (counter < primeTarget)
         {
            if(isPrimeNumber(number))
            {
               primeNumbers.Add(number);
               counter++;
            }
            number++;
         }
         Console.WriteLine("The {0} Prime Number is {1}", primeTarget, primeNumbers[primeTarget - 1]);
         Console.Read();
      }
      private static bool isPrimeNumber(int number)
      {
         for (int i = 2; i < (number/2)+1; i++)
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
