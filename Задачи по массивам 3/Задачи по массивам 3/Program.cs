using System;
class Program
{
    static void Main()
    {
        // Заданный массив чисел
        int[] numbers = { 5, 10, 15, 20, 25,30,35 };

        // Нахождение суммы элементов массива
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Вычисление среднего арифметического
        double average = (double)sum / numbers.Length;

        // Вывод результатов
        Console.WriteLine($"Сумма элементов массива: {sum}");
        Console.WriteLine($"Среднее арифметическое: {average:F2}");
    }
}

