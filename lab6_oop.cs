using System;
using System.Threading;

class Program
{
    // Масив з 15 цілих чисел
    static int[] numbers = new int[15];

    // Метод для ініціалізації масиву випадковими числами
    static void InitializeArray()
    {
        Random rand = new Random();
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = rand.Next(1, 101); // Заповнюємо масив числами від 1 до 100
        }
    }

    // Метод для виведення елементів масиву з парними індексами (T0)
    static void PrintEvenIndexElements()
    {
        Console.WriteLine("Елементи з парними індексами:");
        for (int i = 0; i < numbers.Length; i += 2) // Крок 2 для парних індексів
        {
            Console.WriteLine($"Індекс {i}: {numbers[i]}");
        }
    }

    static void Main()
    {
        // Ініціалізація масиву
        InitializeArray();

        // Створення і запуск потоку T0 для виведення елементів з парними індексами
        Thread T0 = new Thread(PrintEvenIndexElements);
        T0.Start();

        // Оскільки завдання не вимагає додаткового потоку для T1, можемо просто почекати завершення T0
        T0.Join();

        Console.WriteLine("\nЗавершено виконання потоку T0.");
    }
}
