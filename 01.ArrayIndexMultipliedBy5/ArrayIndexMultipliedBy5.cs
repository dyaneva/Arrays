// Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
// Print the obtained array on the console.

using System;

class ArrayIndexMultipliedBy5
{
    static void Main()
    {
        int[] array=new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = 5 * i;
        }
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }
}
