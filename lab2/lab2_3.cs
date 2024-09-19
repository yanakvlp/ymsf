class Program
{
    static void Main(string[] args)
    {
        // 3. Формуємо дві колекції однакової довжини.
        int N = 10; // Кількість елементів в колекціях
        Random rand = new Random();
        List<int> collection1 = new List<int>();
        List<int> collection2 = new List<int>();

        // Заповнюємо колекції випадковими числами в діапазоні [1;10]
        for (int i = 0; i < N; i++)
        {
            collection1.Add(rand.Next(1, 11));
            collection2.Add(rand.Next(1, 11));
        }

        Console.WriteLine("Перша колекція: " + string.Join(", ", collection1));
        Console.WriteLine("Друга колекція: " + string.Join(", ", collection2));

        // Формуємо третю колекцію за умовами
        List<int> collection3 = new List<int>();
        for (int i = 0; i < N; i++)
        {
            // Перевіряємо, чи обидва числа парні або обидва непарні
            if ((collection1[i] % 2 == 0 && collection2[i] % 2 == 0) ||
                (collection1[i] % 2 != 0 && collection2[i] % 2 != 0))
            {
                collection3.Add(1);
            }
            else
            {
                collection3.Add(-1);
            }
        }

        Console.WriteLine("Третя колекція: " + string.Join(", ", collection3));
    }
}