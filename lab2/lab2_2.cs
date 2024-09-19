class Program
{
    static void Main(string[] args)
    {
        // 2. Формуємо колекцію з N цілих випадкових чисел в інтервалі [10;99].
        int N = 10; // Задаємо кількість елементів
        Random rand = new Random();
        List<int> numbers = new List<int>();

        // Заповнюємо колекцію випадковими числами
        for (int i = 0; i < N; i++)
        {
            numbers.Add(rand.Next(10, 100)); // Генеруємо числа в діапазоні [10; 99]
        }

        Console.WriteLine("Початкова колекція: " + string.Join(", ", numbers));

        // Задаємо значення X для суми цифр
        int X = 5; // Ви можете змінити це значення
        int indexToInsert = -1;

        // Знаходимо перше число, де сума цифр дорівнює X
        for (int i = 0; i < numbers.Count; i++)
        {
            int sumOfDigits = numbers[i].ToString().Sum(c => c - '0'); // Сума цифр
            if (sumOfDigits == X)
            {
                indexToInsert = i;
                break;
            }
        }

        // Вставляємо -1 перед знайденим числом
        if (indexToInsert != -1)
        {
            numbers.Insert(indexToInsert, -1);
            Console.WriteLine("Колекція після вставки -1: " + string.Join(", ", numbers));
        }
        else
        {
            Console.WriteLine("Число з сумою цифр, що дорівнює X, не знайдено.");
        }
    }
}