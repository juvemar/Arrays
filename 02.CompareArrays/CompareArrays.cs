//Write a program that reads two integer arrays from the console and compares them element by element.

using System;

class CompareArrays
{
    static void Main()
    {
        bool isequal;
        Console.Write("Enter length of first array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter length of second array: ");
        int m = int.Parse(Console.ReadLine());
        int[] array1 = new int[n];
        int[] array2 = new int[m];
        if (n == m)
        {
            Console.WriteLine("Enter first array: ");
            for (int i = 0; i < n; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter second array: ");
            for (int i = 0; i < n; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] != array2[i])
                {
                    isequal = false;
                    Console.WriteLine("The arrays are not equal.");
                    break;
                }
                else Console.WriteLine("The arrays are equal.");
            }
        }
        else
        {
            Console.WriteLine("The arrays are not equal.");
        }

        Main();
    }
}