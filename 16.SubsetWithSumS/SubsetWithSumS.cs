//We are given an array of integers and a number S.
//Write a program to find if there exists a subset of the elements of the array that has a sum S.

using System;

class SubsetWithSumS
{
    static void Main()
    {
        int[] array = { 5, 2, 5, 7, 4 };
        int sum = 3;//In this case the answer is No.
        //int sum = 6; // In this case the answer is Yes.
        int currentSum = 0;
        int startCheck = 0;
        bool exists = false;

        for (int i = 0; i < array.Length; i++)
        {
            if ((array[i] + currentSum) <= sum)
            {
                currentSum += array[i];
            }
            if (currentSum == sum)
            {
                Console.WriteLine("Yes");
                exists = true;
                break;
            }
            else if (i == array.Length - 1)
            {
                i = startCheck;
                startCheck++;
                currentSum = 0;
            }
        }
        if (!exists)
        {
            Console.WriteLine("No");
        }
    }
}