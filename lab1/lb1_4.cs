using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть речення:");
        string input = Console.ReadLine();

        Console.WriteLine("Введіть букву:");
        char letter = char.ToLower(Console.ReadLine()[0]);

        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        foreach (string word in words)
        {
            if (char.ToLower(word[0]) != letter)
            {
                result += word + " ";
            }
        }

        Console.WriteLine("Нове речення: " + result.Trim());
    }
}
