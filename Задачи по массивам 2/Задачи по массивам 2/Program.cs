using System;

class Program
{
    static void Main()
    {
        // Создание массива строк
        string[] stringArray = { "Mango", "lemon", "orange", "pomegranate", "watermelon  " };

        Console.WriteLine("Введите строку для поиска:");

        // Ввод строки от пользователя
        string userInput = Console.ReadLine();

        // Проверка наличия строки в массиве
        bool isStringFound = false;

        foreach (string str in stringArray)
        {
            if (str.Equals(userInput, StringComparison.OrdinalIgnoreCase))
            {
                isStringFound = true;
                break;
            }
        }

        // Вывод результата
        if (isStringFound)
        {
            Console.WriteLine("Строка найдена!");
        }
        else
        {
            Console.WriteLine("Строка не найдена!");
        }
    }
}
