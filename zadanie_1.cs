using System;

class zadanie_1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        if (input.Length % 2 == 0)
        {
            int halfLength = input.Length / 2;

            string firstHalf = input.Substring(0, halfLength);
            string secondHalf = input.Substring(halfLength);

            string reversedFirstHalf = ReverseString(firstHalf);
            string reversedSecondHalf = ReverseString(secondHalf);

            string result = reversedSecondHalf + reversedFirstHalf;

            Console.WriteLine("Результат: " + result);
        }
        else
        {
            string reversedInput = ReverseString(input);
            string result = reversedInput + input;

            Console.WriteLine("Результат: " + result);
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
