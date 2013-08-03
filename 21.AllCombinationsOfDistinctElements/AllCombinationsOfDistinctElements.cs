// Write a program that reads two numbers N and K and generates all the combinations of K distinct elements 
// from the set [1..N]. Example: N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}

using System;

class AllCombinationsOfDistinctElements
{
    static int n, k;
    //  method for generating all the combinations of distinct elements using recursive call
    static void AllCombinations(int[] array, int current, int number)
    {
        if (current == array.Length)
        {
            Print(array);
            return;
        }
        for (int i = number; i <= n; i++)
        {
            array[current] = i;
            AllCombinations(array, current + 1, i+1);
        }
    }
    // method for printing elements
    static void Print(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
    static void Main()
    {
        Console.Write("Enter number N = ");
        n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K = ");
        k = int.Parse(Console.ReadLine());
        int[] variations = new int[k];
        AllCombinations(variations, 0, 1);
    }
}
