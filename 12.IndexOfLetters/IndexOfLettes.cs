//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;


class IndexOfLetters
{
    static void Main()
    {
        Console.Write("Enter a word of capital letters: ");
        string word = Console.ReadLine();
        char[] alphabet = new char[26];
        int letter = 0;
        for (char c = 'A'; c <= 'Z'; c++)
        {
            alphabet[letter] = c;
            letter++;
        }

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (word[i] == alphabet[j])
                {
                    Console.WriteLine("{0} is on {1} position", word[i], j);
                    j = alphabet.Length;
                }
            }
        }
    }
}