//Write a program that finds the most frequent number in an array.

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        bool bubbled;
        int temp = 0;
        int repeatCount = 1;
        int maxRepeat = 0;
        int winner = 0;
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
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    bubbled = false;
                }
            }
        } while (bubbled == false);

        for (int i = 0; i < n - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                repeatCount++;
                if (maxRepeat < repeatCount)
                {
                    maxRepeat = repeatCount;
                    winner = array[i];
                }
            }
            else repeatCount = 1;
        }
        Console.WriteLine("{0} ({1} times)", winner, maxRepeat);

        Main();
    }
}
