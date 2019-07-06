/*
 *  The prime factors of 13195 are 5, 7, 13 and 29.
 *
 *  What is the largest prime factor of the number 600851475143?
 */

using System;
using System.Collections.Generic;

namespace EulerP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables
            double number = 600851475143;
            List<double> factors = new List<double>();
            List<double> primeFactors = new List<double>();

            // find factors of "number"
            // add them all to a list called "factors"
            GetFactors(number, ref factors);

            // for each factor in the list, write it out to the screen (sanity check)
            foreach (int item in factors)
            {
                Console.WriteLine($"A factor of {number} is {item}");
            }

            // test each factor for "primeness"
            primeFactors = GetPrimeNumbers(factors);

            // write out each prime factor to the screen.
            foreach (int prime in primeFactors)
            {
                Console.WriteLine($"{prime} is prime!");
            }
        }

        static void GetFactors(double number, ref List<double> factors)
        {
            double numLimit = Math.Sqrt(number);

            for (long i = 1; i < numLimit; i+=2)
            {
                if (number % i == 0)
                {
                    factors.Add(i);
                }
            }
        }

        static List<double> GetPrimeNumbers(List<double> factors)
        {
            bool isPrime = true;
            List<double> primeNums = new List<double>();

            foreach (double item in factors)
            {
                isPrime = true;

                for (double i = 2; i < (item / 2); i++)
                {
                    if (item % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime == true)
                {
                    primeNums.Add(item);
                }
            }

            return primeNums;
        }
        
    }
}