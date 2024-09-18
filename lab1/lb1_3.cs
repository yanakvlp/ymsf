class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть речення:");
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string lastWord = words[^1];

        foreach (string word in words)
        {
            if (word != lastWord)
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine(); // Додаємо перехід на новий рядок після виводу
    }
}