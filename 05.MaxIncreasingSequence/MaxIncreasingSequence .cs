// Write a program that finds the maximal increasing sequence in an array. 
// Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.

using System;

class MaxIncreasingSequence
{
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
        int len = 1;
        int maxLen = 0;
        int index = 0;
        // check consecutive increasing elements
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] < array[i + 1])
            {
                len++;
            }
            else
            {
                if (len > maxLen)
                {
                    maxLen = len;
                    index = i;
                }
                len = 1;
            }
        }
        // check last element 
        if (len > maxLen)
        {
            maxLen = len;
            index = array.Length - 1;
        }      
        Console.Write("The maximal sequence of increasing elements is {");
        for (int i = index - maxLen + 1; i < index + 1; i++)
        {
            Console.Write(" {0} ", array[i]);
        }
        Console.WriteLine("}");
    }
}
