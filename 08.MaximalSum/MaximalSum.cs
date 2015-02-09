//Write a program that finds the sequence of maximal sum in given array.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a digit on position {0}:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        string strArray = string.Join(", ", array);
        Console.WriteLine("Your array is: {0}", strArray);

        int currentSum = array[0];
        int startIndex = 0;
        int endIndex = 0;
        int tempIndex = 0;
        int maxSum = array[0];

        for (int i = 0; i < n - 1; i++)
        {
            if (currentSum <= 0)
            {
                startIndex = i;
                currentSum = 0;
            }

            currentSum += array[i];

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                tempIndex = startIndex;
                endIndex = i;
            }
        }

        Console.Write("The sequance with maximal sum is: ");
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (i == endIndex)
            {
                Console.Write(array[i]);
            }
            else Console.Write(array[i] + ", ");
        }
        Console.WriteLine();

        Main();
    }
}