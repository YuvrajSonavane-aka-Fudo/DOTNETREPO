using System;

public class ShuffleString
{
    public static string ShuffleFirstAndLast(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length == 1)
        {
            return input; // No shuffle needed if string is empty or has only one character
        }

        char firstChar = input[0];
        char lastChar = input[input.Length - 1];
        string middle = input.Substring(1, input.Length - 2);

        return lastChar + middle + firstChar;
    }
}
