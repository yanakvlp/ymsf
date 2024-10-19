using System;
using System.Collections.Generic;

class Sportsman
{
    // Поля для зберігання прізвища спортсмена, країни та року народження
    public string Surname { get; set; }
    public string Country { get; set; }
    public int YearOfBirth { get; set; }

    // Конструктор для ініціалізації полів
    public Sportsman(string surname, string country, int yearOfBirth)
    {
        Surname = surname;
        Country = country;
        YearOfBirth = yearOfBirth;
    }

    // Метод, що повертає рядок з інформацією про спортсмена
    public string GetDetails()
    {
        return $"Прізвище: {Surname}, Країна: {Country}, Рік народження: {YearOfBirth}";
    }
}

class Program
{
    static void Main()
    {
        // Список для зберігання спортсменів
        List<Sportsman> sportsmen = new List<Sportsman>();

        // Введення даних про спортсменів
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Введіть дані для спортсмена {i + 1}:");
            Console.Write("Введіть прізвище: ");
            string surname = Console.ReadLine();
            Console.Write("Введіть країну: ");
            string country = Console.ReadLine();
            Console.Write("Введіть рік народження: ");
            int yearOfBirth;
            while (!int.TryParse(Console.ReadLine(), out yearOfBirth)) // Перевірка на коректність вводу числа
            {
                Console.WriteLine("Будь ласка, введіть правильне числове значення для року народження.");
            }

            // Створення об'єкта Sportsman і додавання його до списку
            sportsmen.Add(new Sportsman(surname, country, yearOfBirth));
        }

        // Виведення списку спортсменів за допомогою методу
        Console.WriteLine("\nСписок спортсменів:");
        foreach (var sportsman in sportsmen)
        {
            Console.WriteLine(sportsman.GetDetails());
        }

        // Пошук спортсменів з конкретної країни
        Console.Write("\nВведіть країну для пошуку: ");
        string searchCountry = Console.ReadLine();

        // Підрахунок кількості спортсменів з цієї країни
        int count = 0;
        int youngestYear = int.MaxValue; // Початкове значення для пошуку наймолодшого
        Sportsman youngestSportsman = null;

        foreach (var sportsman in sportsmen)
        {
            if (sportsman.Country == searchCountry)
            {
                count++;
                // Пошук наймолодшого спортсмена з цієї країни
                if (sportsman.YearOfBirth < youngestYear) // Порівняння на наймолодшого
                {
                    youngestYear = sportsman.YearOfBirth;
                    youngestSportsman = sportsman;
                }
            }
        }

        // Виведення результатів
        Console.WriteLine($"\nКількість спортсменів з країни {searchCountry}: {count}");
        if (youngestSportsman != null)
        {
            Console.WriteLine($"Наймолодший спортсмен з країни {searchCountry}: {youngestSportsman.Surname}, Рік народження: {youngestSportsman.YearOfBirth}");
        }
        else
        {
            Console.WriteLine($"Спортсменів з країни {searchCountry} не знайдено");
        }
    }
}
