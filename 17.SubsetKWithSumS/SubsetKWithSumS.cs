//Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
//Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;

class SubsetKWithSumS
{
    static void Main()
    {
        Console.Write(@"Enter length of the array ""n"": ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(@"Enter number of elements ""k"":");
        int k = int.Parse(Console.ReadLine());
        Console.Write(@"Enter sum of the elements ""s"":");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the numbers of the array separated by space:");
        string array = Console.ReadLine();
        string[] stringArr = array.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        int numCounter = 1;
        int currentSum = 0;
        int startCheck = 0; ;
        bool exists = false;

        for (int i = 0; i < stringArr.Length; i++)
        {
            int intArr = int.Parse(stringArr[i]);
            if ((intArr + currentSum) <= s && numCounter < 4)
            {
                currentSum += intArr;
                numCounter++;
            }
            if (currentSum == s && numCounter == 3)
            {
                Console.WriteLine("Yes");
                exists = true;
                break;
            }
            else if (i == stringArr.Length - 1)
            {
                i = startCheck;
                startCheck++;
                currentSum = 0;
                numCounter = 1;
            }
        }
        if (!exists)
        {
            Console.WriteLine("No");
        }
    }
}