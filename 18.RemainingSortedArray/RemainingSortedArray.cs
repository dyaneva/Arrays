// Write a program that reads an array of integers and removes from it a minimal number of elements in such way that 
// the remaining array is sorted in increasing order. Print the remaining sorted array. 
// Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}

using System;
using System.Collections.Generic;

class RemainingSortedArray
{
    static bool Sort(List<int> array)
    {
        bool isSorted = true;
        for (int i = 0; i < array.Count - 1; i++)
        {
            if (!(array[i] <= array[i + 1]))
            {
                isSorted = false;
            }
        }
        return isSorted;
    }
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int combinations = (int)Math.Pow(2, array.Length); // all possible combinations   
        List<int> sortedArray = new List<int>();
        int len = 0;
        int maxLen = 0;
        // check that the remaining array is sorted in increasing order
        for (int i = 1; i < combinations; i++)
        {
            List<int> subset = new List<int>();           
            for (int j = 0; j < array.Length; j++)
            {
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    subset.Add(array[j]);
                    len++;
                }
            }
            // check if the subset is sorted
            if (Sort(subset))
            {
                if (len > maxLen)
                {
                    maxLen = len;
                    sortedArray = subset;
                }
            }
            len = 0;
        }
        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.Write("{0} ", sortedArray[i]);
        }
    }
}