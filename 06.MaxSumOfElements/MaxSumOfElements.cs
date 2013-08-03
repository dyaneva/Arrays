// Write a program that reads two integer numbers N and K and an array of N elements from the console. 
// Find in the array those K elements that have maximal sum.

using System;

class MaxSumOfElements
{
    static void Main()
    {
        Console.Write("Enter number N = ");
        int n = int.Parse(Console.ReadLine());           
        int[] array=new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Element {0} = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        int k;
        Console.Write("Enter number K = ");
        while (int.TryParse(Console.ReadLine(), out k) && k > n)
        {
            Console.Write("Invalid input! Enter k < n! Please try again: ");
        }     
        int sum = 0;
        int maxSum = 0;
        string elements = "";
        string elementsWithMaxSum = "";        
        for (int i = 0; i < array.Length; i++)
        {
            // check outside the array bounds
            if (i+k > n)
            {
                break;
            }
            // calculate sum and determine the sequence of k elements
            for (int j = i; j < i+k; j++)
            {
                sum += array[j];
                elements = elements + " " + array[j];
            }
            // check maximal sum and determine the elements with maximal sum 
            if (sum>maxSum)
            {
                maxSum = sum;
                elementsWithMaxSum = elements;
            }
            sum = 0;            
            elements = "";
        }
        Console.WriteLine("The sequence of k elements with maximal sum is {{{0} }} with sum = {1}", elementsWithMaxSum, maxSum);
          
    }
}