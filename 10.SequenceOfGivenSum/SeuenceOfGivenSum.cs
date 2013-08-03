//Write a program that finds in given array of integers a sequence of given sum S (if present). 
// Example: {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}	

using System;
using System.Text;

class SeuenceOfGivenSum
{
    static void Main()
    {
        Console.Write("Enter sum: ");
        int sum = int.Parse(Console.ReadLine());
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }       
        string elements = "";
        StringBuilder currentElements = new StringBuilder();
        // check sequence of given sum
        for (int i = 0; i < array.Length; i++)
        {
            int currentSum = 0;
            for (int j = i; j < array.Length; j++)
            {
                currentSum += array[j];
                currentElements.AppendFormat("{0} ", array[j]);
                if (currentSum == sum)
                {
                    elements = currentElements.ToString();
                    Console.WriteLine("The sequence of given sum is: {0}", elements);
                }                
                if (currentSum > sum)
                {
                    currentSum = 0;
                    currentElements.Clear();
                    break;
                }
            }
        }
    }
}
