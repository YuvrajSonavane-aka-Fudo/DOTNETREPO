using System;

public class PalindromeChecker
{
    public static bool IsPalindromeWithoutRecursion(int number)
    {
        int original = number;
        int reversed = 0;
        while (number != 0)
        {
            reversed = reversed * 10 + number % 10;
            number /= 10;
        }
        return original == reversed;
    }

    public static bool IsPalindromeWithRecursion(int number, int reversed = 0)
    {
        if (number == 0)
        {
            return number == reversed;
        }
        reversed = reversed * 10 + number % 10;
        return IsPalindromeWithRecursion(number / 10, reversed);
    }
}
