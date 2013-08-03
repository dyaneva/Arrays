// Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first word (char array): ");
        string firstChar = Console.ReadLine();
        Console.Write("Enter the second word (char array): ");
        string secondChar = Console.ReadLine();
        // convert string to char array 
        char[] firstArray = firstChar.ToCharArray();
        char[] secondArray = secondChar.ToCharArray();        
        // comparing two char arrays
        bool areEqual = true;
        if (firstArray.Length==secondArray.Length)
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i]!=secondArray[i])
                {
                    areEqual = false;
                    break;
                }
            }
        }
        else
        {
            areEqual = false;    
        }
        Console.WriteLine("The two arrays are equal: {0}", areEqual);
    }
}
