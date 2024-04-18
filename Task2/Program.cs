// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static void Main()
    {
        int m = 0; // Значение m
        int n = 0; // Значение n

        Console.WriteLine("Введите значение m:");
        string inputM = Console.ReadLine();
        if (!int.TryParse(inputM, out m))
        {
            Console.WriteLine("Некорректный ввод для m.");
            return;
        }

        Console.WriteLine("Введите значение n:");
        string inputN = Console.ReadLine();
        if (!int.TryParse(inputN, out n))
        {
            Console.WriteLine("Некорректный ввод для n.");
            return;
        }

        Console.WriteLine($"Функция Аккермана для m = {m}, n = {n} равна {Ackermann(m, n)}");
    }

    static int Ackermann(int m, int n)
    {
        // Базовый случай
        if (m == 0)
        {
            return n + 1;
        }
        // Рекурсивные случаи
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }
}