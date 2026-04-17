using System;

class Program
{
    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number < 2) return false; // 0 and 1 are not prime
        if (number == 2) return true; // 2 is prime
        if (number % 2 == 0) return false; // Even numbers > 2 are not prime

        // Check divisibility up to square root of number
        int limit = (int)Math.Sqrt(number);
        for (int i = 3; i <= limit; i += 2)
        {
            if (number % i == 0) return false;
        }
        return true;
    }

    static void Main()
    {
        // 1. Prime numbers from 1 to 100
        Console.WriteLine("Prime numbers from 1 to 100:");
        for (int i = 1; i <= 100; i++)
        {
            if (IsPrime(i))
                Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 2. Multiples of 8 from 1 to 80
        Console.WriteLine("Multiples of 8 from 1 to 80:");
        for (int i = 8; i <= 80; i += 8)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine("\n");

        // 3. Multiples of 10 from 1 to 100
        Console.WriteLine("Multiples of 10 from 1 to 100:");
        for (int i = 10; i <= 100; i += 10)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

