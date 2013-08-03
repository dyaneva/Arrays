// Write a program that finds the index of given element in a sorted array of integers by using 
// the binary search algorithm 

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        Console.Write("Enter key (element of the array): ");
        int key = int.Parse(Console.ReadLine());
        // sort the array and print the sorted array
        Array.Sort(array);
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
        int iMin = 0;
        int iMax = array.Length - 1;
        // binary search algorithm
        while (iMax >= iMin)
        {
            int iMid = (iMin + iMax) / 2;
            if (array[iMid] < key)
            {
                iMin = iMid + 1;
            }
            else if (array[iMid] > key)
            {
                iMax = iMid - 1;
            }
            else
            {
                Console.WriteLine("The index of the given element is: {0}", iMid);
                break;
            }
        }
        if (iMax<iMin)
        {
            Console.WriteLine("This element is not found in the array.");
        }
    }
}
