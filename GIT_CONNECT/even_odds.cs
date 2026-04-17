using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Even numbers from 1 to 100:");
        PrintEvenNumbers(1, 100);

        Console.WriteLine("\nOdd numbers from 1 to 100:");
        PrintOddNumbers(1, 100);

        Console.WriteLine("\nAll numbers from 1 to 100:");
        PrintAllNumbers(1, 100);
    }

    // Prints even numbers in the given range
    static void PrintEvenNumbers(int start, int end)
    {
        if (start > end)
        {
            Console.WriteLine("Invalid range.");
            return;
        }

        for (int i = start; i <= end; i++)
        {
            if (i % 2 == 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Prints odd numbers in the given range
    static void PrintOddNumbers(int start, int end)
    {
        if (start > end)
        {
            Console.WriteLine("Invalid range.");
            return;
        }

        for (int i = start; i <= end; i++)
        {
            if (i % 2 != 0)
                Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    // Prints all numbers in the given range
    static void PrintAllNumbers(int start, int end)
    {
        if (start > end)
        {
            Console.WriteLine("Invalid range.");
            return;
        }

        for (int i = start; i <= end; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}

