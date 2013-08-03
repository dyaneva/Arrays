// Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
// Find in the array a subset of K elements that have sum S or indicate about its absence.

using System;
using System.Text;

class SubsetOfElementsWithSum
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int k;
        Console.Write("Enter number K = ");
        while (int.TryParse(Console.ReadLine(), out k) && k > n)
        {
            Console.Write("Invalid input! Enter k < n! Please try again: ");
        } 
        Console.Write("Enter sum = ");
        int sum = int.Parse(Console.ReadLine());
        int combinations = (int)Math.Pow(2, array.Length); // all possible combinations       
        StringBuilder subset = new StringBuilder();
        bool hasSum = false;
        // check subset of k elements with given sum using bitwise operations
        for (int i = 1; i < combinations; i++)
        {
            int counter = 0;
            int currentSum = 0;
            subset.Clear();
            for (int j = 0; j < array.Length; j++)
            {                        
                int mask = 1 << j;
                int nAndMask = i & mask;
                int bit = nAndMask >> j;
                if (bit == 1)
                {
                    currentSum += array[j];
                    subset.AppendFormat("{0} ", array[j]);
                    counter++;
                }
            }
            if (currentSum == sum && counter == k)
            {
                Console.WriteLine("Yes {{{0}}} = {1} ", subset, sum);
                hasSum = true;
            }
        }
        if (!hasSum)
        {
            Console.WriteLine("No subset with the given sum");
        }
    }
}