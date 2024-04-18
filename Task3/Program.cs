// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;

class Program
{
    static void Main()
    {
        int[] array = new int[] { 1, 2, 3, 4, 5 }; // Пример массива
        RecursivePrintArray(array, array.Length - 1);
    }

    static void RecursivePrintArray(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            RecursivePrintArray(array, index - 1);
        }
    }
}
