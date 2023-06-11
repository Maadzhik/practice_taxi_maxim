using System;

class zadanie_2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();
        string allowedChars = "abcdefghijklmnopqrstuvwxyz"; 

        
        foreach (char c in input.ToLower())
        { 
            if (!allowedChars.Contains(c))
            { 
                Console.WriteLine("Ошибка: символ \'{0}\' не является буквой из английского алфавита в нижнем регистре.", c);
                return; 
            }
        }

        if (input.Length % 2 == 0)
        {
            int halfLength = input.Length / 2;

            string firstHalf = input.Substring(0, halfLength);
            string secondHalf = input.Substring(halfLength);

            string reversedFirstHalf = ReverseString(firstHalf);
            string reversedSecondHalf = ReverseString(secondHalf);

            string result = reversedSecondHalf + reversedFirstHalf;

            Console.WriteLine("Обработанная строка: " + result);
        }
        else
        {
            string reversedInput = ReverseString(input);
            string result = reversedInput + input;

            Console.WriteLine("Обработанная строка: " + result);
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}