using System;

class Program
{
    // функция для вычисления среднего арифметического цифр числа
    static double AverageOfDigits(int number)
    {
        // работаем с модулем числа на случай отрицательных значений
        int temp = Math.Abs(number);

        // если число равно 0, среднее арифметическое его цифр равно 0
        if (temp == 0) return 0;

        double sum = 0;
        int count = 0;

        while (temp > 0)
        {
            sum += temp % 10; // добавляем последнюю цифру к сумме
            count++;          // увеличиваем счётчик цифр
            temp /= 10;       // убираем последнюю цифру
        }

        return sum / count;   // среднее арифметическое цифр
    }

    static void Main()
    {
        Console.Write("Введите количество чисел (N): ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write("Введите число #{0}: ", i);
            int number = int.Parse(Console.ReadLine());

            double avg = AverageOfDigits(number);

            // выводим результат с точностью до двух знаков после запятой
            Console.WriteLine("Среднее арифметическое цифр числа {0} = {1:F2}", number, avg);
        }
    }
}