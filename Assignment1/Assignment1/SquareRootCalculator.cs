using System;

public class SquareRootCalculator
{
    public static void CalculateSquareRoot()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        try
        {
            double number = Convert.ToDouble(input);
            if (number < 0)
            {
                throw new ArgumentException("Cannot calculate the square root of a negative number.");
            }
            Console.WriteLine($"The square root of {number} is {Math.Sqrt(number)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter a valid number.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
