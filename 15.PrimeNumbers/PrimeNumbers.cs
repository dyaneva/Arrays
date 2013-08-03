// Write a program that finds all prime numbers in the range [1...10 000 000]. 
// Use the sieve of Eratosthenes algorithm 

using System;

class PrimeNumbers
{
    static void Main()
    {
        // all elements - false by default
        bool[] primeNumbers = new bool[10000000];
        // check prime numbers
        for (int i = 2; i < Math.Sqrt(primeNumbers.Length); i++) // this variant was shown at workshop from C#1
        {
            if (primeNumbers[i]==false)
            {
                for (int j = i*i; j < primeNumbers.Length; j = j + i)
                {
                    primeNumbers[j] = true;
                }
            }
        }
        for (int i = 2; i < primeNumbers.Length; i++)
        {
            if (primeNumbers[i]==false)
            {
                Console.Write("{0} ",i);
            }
        }        
    }    
}
