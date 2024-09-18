using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();
        int length = input.Length;

        if (length % 2 == 1)
        {
            // Непарна довжина
            int midIndex = length / 2;
            input = input.Remove(midIndex, 1);
        }
        else
        {
            // Парна довжина
            int midIndex = length / 2;
            input = input.Remove(midIndex - 1, 2);
        }

        Console.WriteLine("Рядок після видалення: " + input);
    }
}
