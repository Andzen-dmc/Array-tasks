using System;

class Program
{
    static void Main()
    {
        // Заданный массив целых чисел
        int[] numbers = { 2, 7, 15, 8, 3, 12, 5, 10 };

        Console.WriteLine("Нечетные числа в массиве:");

        // Перебор элементов массива и вывод нечетных чисел
        foreach (int number in numbers)
        {
            if (IsOdd(number))
            {
                Console.WriteLine(number);
            }
        }
    }

    static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }
}

