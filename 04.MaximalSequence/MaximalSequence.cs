//Write a program that finds the maximal sequence of equal elements in an array.

using System;

class MaximalSequence
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        int winner = 0;
        int count = 0;
        int mostCount = 0;
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a digit on position {0}:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        string strArray = string.Join(", ", array);
        Console.WriteLine("Your array is: {0}", strArray);

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                count++;
                if (mostCount < count)
                {
                    mostCount = count;//takes the number of the digits of the maximal sequence
                    winner = i + 1 - count;// this is the position of the first digit of the maximal sequence
                }
            }
            else
            {
                count = 0;
            }
        }
        Console.WriteLine("Maximal sequence:");
        for (int i = 0, j = winner; i <= mostCount; i++, j++)
        {
            if (i < mostCount)
            {
                Console.Write(array[j] + ", ");
            }
            else
            {
                Console.Write(array[j]);
            }
        }
        Console.WriteLine();
        Console.WriteLine();

        Main();
    }
}