using System;

class zadanie_2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку: ");
        string input = Console.ReadLine();
        string allowedChars = "abcdefghijklmnopqrstuvwxyz";
        int[] charCount = new int[26]; // массив для подсчета количества каждого символа

        foreach (char c in input.ToLower())
        {
            if (!allowedChars.Contains(c))
            {
                Console.WriteLine("Ошибка: символ \'{0}\' не является буквой из английского алфавита в нижнем регистре.", c);
                return;
            }
            else
            {
                charCount[c - 'a']++; // увеличиваем счетчик соответствующего символа
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

            // выводим информацию о количестве каждого символа
            for (int i = 0; i < 26; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine("Cимвол \'{0}\' входил в обработанную строку {1} раз(а).", (char)('a' + i), charCount[i]);
                }
            }
        }
        else
        {
            string reversedInput = ReverseString(input);
            string result = reversedInput + input;

            Console.WriteLine("Обработанная строка: " + result);

            // выводим информацию о количестве каждого символа
            for (int i = 0; i < 26; i++)
            {
                if (charCount[i] > 0)
                {
                    Console.WriteLine("Cимвол \'{0}\' входил в обработанную строку {1} раз(а).", (char)('a' + i), charCount[i]);
                }
            }
        }
    }

    static string ReverseString(string str)
    {
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}