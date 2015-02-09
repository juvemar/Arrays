//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static int BinSearch(int[] array, int key)
    {
        Array.Sort(array);
        int first = 0;
        int last = array.Length - 1;
        while (last >= first)
        {
            int mid = (first + last) / 2;
            if (array[mid] < key)
            {
                first = mid + 1;
            }
            else if (array[mid] > key)
            {
                last = mid - 1;
            }
            else
            {
                return mid;
            }
        }
        return -1;
    }
    static void Main()
    {
        Console.WriteLine("Binary search algorith.");
        int[] sortedArr = new int[8] { 2, 3, 6, 1, 2, 22, 43, 9 };
        int key = 2;
        Console.WriteLine(BinSearch(sortedArr, key));
    }
}