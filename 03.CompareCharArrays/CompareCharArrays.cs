//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.Write("Enter first array length: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter second array length: ");
        int m = int.Parse(Console.ReadLine());
        char[] array1 = new char[n];
        char[] array2 = new char[m];
        bool isequal = true;
        if (n == m)
        {

            Console.WriteLine("Enter first array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter character on position {0}: ", i);
                array1[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter second array: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write("Enter character on position {0}: ", i);
                array2[i] = char.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (array1[i] != array2[i])
                {
                    isequal = false;
                }
            }
        }
        else isequal = false;
        Console.WriteLine("The arrays are equal. - " + isequal);

        Main();
    }
}