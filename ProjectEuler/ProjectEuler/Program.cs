using System;
using System.Collections;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION:-
            //The prime factors of 13195 are 5, 7, 13 and 29.
            //What is the largest prime factor of the number 600851475143 ?

            //SOLUTION:-
            long number = 600851475143;
            long nMax = (long)Math.Sqrt(number); //Approximation of highest possible factor

            ArrayList factors = new ArrayList();
            Console.Write("Determining a list of Prime Factors: ");

            for (int n = 2; n < nMax; n++)
            {
                if ((number % n) == 0)
                {
                    factors.Add(n);
                }
            }

            //Remove factors of factors
            var k = 0;
            do
            {
                for (int i = k + 1; i < factors.Count; i++)
                {
                    if (Convert.ToInt64(factors[i]) % Convert.ToInt64(factors[k]) == 0)
                    {
                        factors.Remove(factors[i]);
                        i--;
                    }
                }
                k++;
            }
            while (k < factors.Count);

            //Display the list of Prime Factors
            foreach (var item in factors)
            {
                Console.Write(item + ", ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The highest Prime Factor is: {0}", factors[(factors.Count) - 1]);
            Console.ReadKey();
        }
    }
}
