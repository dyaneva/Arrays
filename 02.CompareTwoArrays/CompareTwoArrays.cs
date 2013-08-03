// Write a program that reads two arrays from the console and compares them element by element.

using System;

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = int.Parse(Console.ReadLine());
        string[] firstArray = new string[n];
        string[] secondArray = new string[n];
        bool areEqual = true;
        Console.WriteLine("Enter elements of the first array:");
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            firstArray[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter elements of the second array:");
        for (int i = 0; i < firstArray.Length; i++)
        {
            Console.Write("Element {0}: ", i);
            secondArray[i] = Console.ReadLine();
        }
        // comparing two arrays
        for (int i = 0; i < firstArray.Length; i++)
        {
            if (firstArray[i]!=secondArray[i])
            {
                areEqual = false;
                break;
            }            
        }
        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    }
}
