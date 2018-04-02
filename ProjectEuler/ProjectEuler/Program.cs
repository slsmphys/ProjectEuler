using System;
using System.Collections;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION:-
            //2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            //What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

            //SOLUTION:-
            Console.WriteLine("Calculating...");

            int n = 1; //start position

            ArrayList validList = new ArrayList();

            do
            {
                for (int i = 1; i < 21; i++)
                {
                    if (n % i == 0)
                    {
                        validList.Add(i);
                    }
                    else
                    {
                        validList.Clear();
                        n++;
                        break;
                    }
                }

            } while (validList.Count != 20);

            Console.WriteLine(n.ToString());
            Console.Read();
        }
    }
}
