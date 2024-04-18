// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите число M: ");
        int M = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите число N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        
        PrintNaturalNumbersInRange(M, N);
    }
    
    static void PrintNaturalNumbersInRange(int start, int end)
    {
        if (start > end)
            return;
        
        Console.WriteLine(start);
        PrintNaturalNumbersInRange(start + 1, end);
    }
}