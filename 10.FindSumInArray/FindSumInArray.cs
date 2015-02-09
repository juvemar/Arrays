//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
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
        Console.Write("Enter the sum you want to be found: ");
        int s = int.Parse(Console.ReadLine());

        string strArray = string.Join(", ", array);
        Console.WriteLine("Your array is: {0}", strArray);

        int currSum = 0;
        int startIndex = 0;

        for (int i = 0; i < n - 1; i++)
        {
            currSum += array[i];
            startIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                currSum += array[j];
                if (currSum == s)
                {
                    for (int k = startIndex; k <= j; k++)
                    {
                        if (k == j)
                        {
                            Console.Write(array[k]);
                        }
                        else Console.Write(array[k] + ", ");
                    }
                    break;
                }
            }
            currSum = 0;
        }
        Console.WriteLine();

        Main();
    }
}