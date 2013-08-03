// Write a program that finds the maximal sequence of equal elements in an array.
// Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.

using System;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array=new int[n];
        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int len = 1;
        int maxLen = 0;
        int element = 0;
        // check consecutive equal elements
        for (int i = 0; i < array.Length-1; i++)
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
        Console.Write("The maximal sequence of equal elements is { ");
        for (int i = 0; i < maxLen; i++)
        {
            Console.Write("{0} ", element);
        }
        Console.WriteLine("}");
    }
}
