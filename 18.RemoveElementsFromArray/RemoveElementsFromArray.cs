//Write a program that reads an array of integers
//and removes from it a minimal number of elements in such a way that the remaining array is sorted in increasing order.
//Print the remaining sorted array.

using System;//Недовършена!!!!!!!

class RemoveElementsFromArray
{
    static void Main()
    {
        int[] array = { 6, 1, 4, 3, 0, 3, 6, 4, 5 };
        int[] newArray = new int[array.Length];
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1; i++)
            {
                if (array[0] > array[i + 1])
                {
                    newArray[j] = array[i];
                    i++;
                    break;
                }
            }
        }
    }
}