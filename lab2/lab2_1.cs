using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // 1. Формуємо колекцію з N цілих випадкових чисел в інтервалі [1;25].
        int N = 10; // Задаємо кількість елементів
        Random rand = new Random();
        List<int> numbers = new List<int>();

        // Заповнюємо колекцію випадковими числами
        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(1, 26)); // Генеруємо числа в діапазоні [1; 25]
        }

        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));

        // Видаляємо числа, що починаються з цифри 1
        numbers.RemoveAll(num => num.ToString().StartsWith("1"));

        Console.WriteLine("Колекція після видалення чисел, що починаються з 1: " + string.Join(", ", numbers));
    }
}
