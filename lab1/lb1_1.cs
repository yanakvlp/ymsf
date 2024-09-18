class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть рядок:");
        string input = Console.ReadLine();

        int countA = 0, countB = 0;

        foreach (char c in input.ToUpper())
        {
            if (c == 'A') countA++;
            else if (c == 'B') countB++;
        }

        if (countA > countB)
            Console.WriteLine("Буква A зустрічається частіше.");
        else if (countB > countA)
            Console.WriteLine("Буква B зустрічається частіше.");
        else
            Console.WriteLine("Букви A і B зустрічаються однакову кількість разів.");
    }
}