using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Вход");
        string lines = Console.ReadLine();
        Regex newReg = new Regex(@"[^a-z]", RegexOptions.None);
        MatchCollection matches = newReg.Matches(lines);
        if (matches.Count > 0)
        {
            foreach (Match mat in matches)
            {
                Console.WriteLine(@"Ошибка,недопустимый символ:" + mat.Value);
            }
        }
        else
        {
            string result = ProcessString(lines);
            Console.WriteLine($"Выход {result}");
        }
    }

    static string ProcessString(string input)
    {
        int length = input.Length;

        if (length % 2 == 0)
        {
            int midIndex = length / 2;
            string firstHalf = input.Substring(0, midIndex);
            string secondHalf = input.Substring(midIndex);
            return ReverseString(firstHalf) + ReverseString(secondHalf);
        }
        else
        {
            return ReverseString(input) + input;
        }
    }

    static string ReverseString(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}