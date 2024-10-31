using System;

public class TTriangle<T> where T : struct, IComparable<T>
{
    // Поля для зберігання довжин сторін трикутника
    private readonly T a;
    private readonly T b;
    private readonly T c;

    // Конструктор з параметрами для сторін
    public TTriangle(T a, T b, T c)
    {
        // Перевірка на коректність сторін
        if (IsValidTriangle(a, b, c))
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        else
        {
            throw new ArgumentException("Неможливо створити трикутник з такими сторонами");
        }
    }

    // Обчислення периметра
    public double Perimeter() => Convert.ToDouble(a) + Convert.ToDouble(b) + Convert.ToDouble(c);

    // Обчислення площі за формулою Герона
    public double Area()
    {
        double s = Perimeter() / 2;
        double da = Convert.ToDouble(a), db = Convert.ToDouble(b), dc = Convert.ToDouble(c);
        return Math.Sqrt(s * (s - da) * (s - db) * (s - dc));
    }

    // Перевантаження оператора + для додавання сторін
    public static TTriangle<T> operator +(TTriangle<T> t1, TTriangle<T> t2) =>
        new TTriangle<T>((dynamic)t1.a + t2.a, (dynamic)t1.b + t2.b, (dynamic)t1.c + t2.c);

    // Перевантаження оператора * для множення сторін на скаляр
    public static TTriangle<T> operator *(TTriangle<T> t, double multiplier) =>
        new TTriangle<T>((dynamic)t.a * multiplier, (dynamic)t.b * multiplier, (dynamic)t.c * multiplier);

    // Перевірка коректності сторін трикутника
    private bool IsValidTriangle(T a, T b, T c)
    {
        double da = Convert.ToDouble(a), db = Convert.ToDouble(b), dc = Convert.ToDouble(c);
        return da + db > dc && da + dc > db && db + dc > da;
    }
}

// Програма-клієнт для тестування
class Program
{
    static void Main()
    {
        try
        {
            var triangle = new TTriangle<double>(3, 4, 5);
            Console.WriteLine($"Периметр: {triangle.Perimeter()}");
            Console.WriteLine($"Площа: {triangle.Area()}");

            // Демонстрація перевантаження оператора +
            var triangle2 = triangle + triangle;
            Console.WriteLine($"Периметр після додавання: {triangle2.Perimeter()}");

            // Демонстрація перевантаження оператора *
            var scaledTriangle = triangle * 2;
            Console.WriteLine($"Периметр після множення: {scaledTriangle.Perimeter()}");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Помилка: {e.Message}");
        }
    }
}

