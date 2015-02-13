//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write(@"Enter ""n"": ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(@"Enter ""k"" : ");
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        bool bubbled = true;
        int temp;

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter a digit on position {0}:", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        string strArray = string.Join(", ", array);
        Console.WriteLine("Your array is: {0}", strArray);

        do
        {
            bubbled = true;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    bubbled = false;
                }
            }
        } while (bubbled == false);

        Console.WriteLine("The {0} elements with maximal sum are: ", k);
        for (int j = 0; j < k; j++)
        {
            if (j < k - 1)
            {
                Console.Write(array[j] + ", ");
            }
            else Console.Write(array[j]);
        }
        Console.WriteLine();
        Console.WriteLine();

        Main();
    }
}