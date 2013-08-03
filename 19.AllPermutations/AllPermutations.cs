// Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
// Example: n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}

using System;

class AllPermutations
{
    static void Change(ref int a, ref int b)
    {
        if (a == b) return;
        a ^= b;
        b ^= a;
        a ^= b; 
    }
    static void SetPermutations(int[] array)
    {
        int len = array.Length - 1;
        Permutations(array, 0, len);
    }
    static void Permutations(int[] array, int current, int length)
    {
        if (current == length)
        {
            for (int i = 0; i <= length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = current; i <= length; i++)
            {
                Change(ref array[i], ref array[current]);
                Permutations(array, current + 1, length);
                Change(ref array[i], ref array[current]);
            }
        }
    }
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] arrayPermutation = new int[n];
        for (int i = 0; i < arrayPermutation.Length; i++)
        {
            arrayPermutation[i] = i+1;            
        }
        SetPermutations(arrayPermutation); 
    }
}
