using System;
using System.Collections;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            //QUESTION:-
            //A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
            //Find the largest palindrome made from the product of two 3-digit numbers.

            //SOLUTION:-
            int product = 0;
            int start = 100;

            string numberForward = "";
            string numberBackward = "";

            ArrayList palindrome = new ArrayList();

            for (int i = start; i < 1000; i++)
            {
                for (int j = start; j < 1000; j++)
                {
                    product = i * j;
                    //Check to see if product is a palindrome
                    numberForward = product.ToString();
                    numberBackward = ReverseString(numberForward);

                    if (numberForward == numberBackward)
                    {
                        palindrome.Add(product);
                    }
                }
                start++;
            }
            palindrome.Sort();

            Console.WriteLine("The highest palindrome produced by the product of two 3-digit numbers is: {0}", palindrome[(palindrome.Count) - 1]);
            Console.Read();
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
