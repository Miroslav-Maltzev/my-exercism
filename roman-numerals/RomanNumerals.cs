using System;

public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string result = "";
        int[] values = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        string[] symbols = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        for (int i = 0; i < values.Length && value >= 0; i++)
        {
            while (values[i] <= value)
            {
                value -= values[i];
                result += symbols[i];
            }
        }
        return result;
    }
}