// Write a program that finds the most frequent number in an array. 
// Example: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)

using System;

class MostFrequentNumber
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        // sort the array
        Array.Sort(array);
        // check maximal sequence of equal elements
        int len = 1;
        int maxLen = 0;
        int element = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] == array[i + 1])
            {
                len++;
            }
            else
            {
                if (len > maxLen)
                {
                    maxLen = len;
                    element = array[i];
                }
                len = 1;
            }
        }
        // check last element 
        if (len > maxLen)
        {
            maxLen = len;
            element = array[array.Length - 1];
        }
        Console.WriteLine("The most frequent number is {0} ({1} times)", element, maxLen);
    }
}
