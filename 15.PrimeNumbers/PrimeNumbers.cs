//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;

class PrimeNumbers
{
    static void Main()
    {
        bool[] a = new bool[10000000];
        for (int j = 2; j < Math.Sqrt(a.Length); j++)
        {
            if (a[j] == false)
            {
                for (int k = j * j; k < a.Length; k = k + j)
                {
                    a[k] = true;
                }
            }
        }
        for (int i = 2; i < a.Length; i++)
        {
            if (a[i] == false)
            {
                Console.WriteLine("{0}", i);
            }
        }
        Console.WriteLine();
    }
}