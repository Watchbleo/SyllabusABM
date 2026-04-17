using System;
public class Program
{
   // Function to calculate sum of two integers
   public static int Sum(int num1, int num2)
   {
       return num1 + num2;
   }
   public static void Main()
   {
       Console.WriteLine("Function to calculate the sum of two numbers:");
       Console.WriteLine("---------------------------------------------");
       Console.Write("Enter the first number: ");
       int firstNumber = Convert.ToInt32(Console.ReadLine());
       Console.Write("Enter the second number: ");
       int secondNumber = Convert.ToInt32(Console.ReadLine());
       int result = Sum(firstNumber, secondNumber);
       Console.WriteLine($"\nThe sum of {firstNumber} and {secondNumber} is: {result}");
   }
}
