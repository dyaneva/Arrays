// We are given an array of integers and a number S. Write a program to find if there exists a subset of the elements
// of the array that has a sum S. Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)

using System;
using System.Text;

class SubsetOfSum
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
        Console.Write("Enter sum = ");
        int sum = int.Parse(Console.ReadLine());
        int combinations = (int)Math.Pow(2, array.Length); // all possible combinations       
        StringBuilder subset = new StringBuilder();
        bool hasSum = false;
        // check subset with given sum using bitwise operations
        for (int i = 1; i < combinations; i++)
        {
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
                }
            }
            if (currentSum == sum)
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
 
