// Write a program that sorts an array of integers using the merge sort algorithm. 

using System;

class MergeSort
{
    // method for recursively merging two arrays
    private static int[] MergeArray(int[] array)
    {
        if (array.Length <= 1)
        {
            return array;
        }
        int middle = array.Length / 2;
        int[] left = new int[middle];
        int[] right = new int[array.Length - middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        for (int i = middle, j = 0; i < array.Length; i++, j++)
        {
            right[j] = array[i];
        }
        left = MergeArray(left);
        right = MergeArray(right);
        return MergeSortAlgorithm(left, right);
    }
    // method for merging two arrays
    private static int[] MergeSortAlgorithm(int[] left, int[] right)
    {
        int[] array = new int[left.Length + right.Length];
        int indexLeft = 0;
        int indexRight = 0;
        int index = 0;
        while (index < array.Length)
        {
            if ((indexRight == right.Length) || ((indexLeft < left.Length)&&(left[indexLeft] < right[indexRight])))
            {
                array[index] = left[indexLeft];
                indexLeft++;    
            }
            else 
            {
                array[index] = right[indexRight];
                indexRight++;                    
            }
            index++;
        }
        return array;
    }
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int[] sortedArray = MergeArray(array);
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.Write("{0} ", sortedArray[i]);
        }
    }
}
