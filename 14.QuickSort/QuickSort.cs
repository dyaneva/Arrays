// Write a program that sorts an array of strings using the quick sort algorithm. 

using System;
using System.Collections.Generic;
using System.Linq;

class QuickSort
{
    // method for sorting with quick sort algorithm
    static List<string> QuickSortAlgorithm(List<string> unsorted)
    {        
        List<string> less = new List<string>();
        List<string> greater = new List<string>();
        List<string> sorted = new List<string>();
        int indexPivot = unsorted.Count / 2;
        if (unsorted.Count > 0)
        {
            for (int i = 0; i < unsorted.Count; i++)
            {
                if (i != indexPivot)
                {
                    if (unsorted[i].CompareTo(unsorted[indexPivot]) <= 0)
                    {
                        less.Add(unsorted[i]);
                    }
                    else
                    {
                        greater.Add(unsorted[i]);
                    }
                }
            } 
            less = QuickSortAlgorithm(less);
            greater = QuickSortAlgorithm(greater);
            sorted.AddRange(less);
            sorted.Add(unsorted[indexPivot]);
            sorted.AddRange(greater);
        }
        return sorted;        
    }
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        string[] array = new string[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = Console.ReadLine();
        }
        List<string> sortedArray = array.ToList();
        sortedArray = QuickSortAlgorithm(sortedArray);
        for (int i = 0; i < sortedArray.Count; i++)
        {
            Console.Write("{0} ", sortedArray[i]);
        }
    }
}