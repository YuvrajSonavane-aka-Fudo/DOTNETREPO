using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Assignment 1 - Choose a program to run:");

        Console.WriteLine("1. Shuffle first and last characters of a string");
        Console.WriteLine("2. Sum of digits of an integer");
        Console.WriteLine("3. Palindrome check (recursive and non-recursive)");
        Console.WriteLine("4. Square root calculation with exception handling");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                // Shuffle the string
                Console.WriteLine("Enter a string:");
                string inputString = Console.ReadLine();
                string shuffledString = ShuffleString.ShuffleFirstAndLast(inputString);
                Console.WriteLine($"Shuffled string: {shuffledString}");
                break;

            case 2:
                // Sum of digits
                Console.WriteLine("Enter an integer:");
                int number = Convert.ToInt32(Console.ReadLine());
                int sum = SumOfDigits.CalculateSumOfDigits(number);
                Console.WriteLine($"Sum of digits: {sum}");
                break;

            case 3:
                // Palindrome check
                Console.WriteLine("Enter a number to check for palindrome:");
                int palindromeNumber = Convert.ToInt32(Console.ReadLine());

                bool isPalindromeNoRecursion = PalindromeChecker.IsPalindromeWithoutRecursion(palindromeNumber);
                bool isPalindromeWithRecursion = PalindromeChecker.IsPalindromeWithRecursion(palindromeNumber);

                Console.WriteLine($"Palindrome without recursion: {isPalindromeNoRecursion}");
                Console.WriteLine($"Palindrome with recursion: {isPalindromeWithRecursion}");
                break;

            case 4:
                // Square root calculation
                SquareRootCalculator.CalculateSquareRoot();
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
