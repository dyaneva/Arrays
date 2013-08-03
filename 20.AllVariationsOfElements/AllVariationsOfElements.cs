// Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. 
// Example:	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}

using System;

class AllVariationsOfElements
{
    //  method for generating all the variations of elements using recursive call
    static void AllVariations(int[] array, int current, int length)
    {
        if (current == array.Length)
        {
            Print(array);
            return;
        }
        for (int i = 1; i <= length; i++)
        {
            array[current] = i;
            AllVariations(array, current + 1, length);
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
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number K = ");
        int k = int.Parse(Console.ReadLine());
        int[] variations=new int[k];
        AllVariations(variations, 0, n);
    }
}
