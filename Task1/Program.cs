using System;

// Класс для обработки входных данных и вывода результата
class UserInputToCompileForTest
{
    // Вычисление сумм по строкам (на выходе массив с суммами строк)
    public static int[] SumRows(int[,] array)
    {
        int rowCount = array.GetLength(0);
        int colCount = array.GetLength(1);
        int[] sums = new int[rowCount];

        for (int i = 0; i < rowCount; i++)
        {
            for (int j = 0; j < colCount; j++)
            {
                sums[i] += array[i, j];
            }
        }

        return sums;
    }

    // Получение индекса минимального элемента в одномерном массиве
    public static int MinIndex(int[] array)
    {
        int minIndex = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < array[minIndex])
            {
                minIndex = i;
            }
        }
        return minIndex;
    }

    // Вывод результата
    public static void PrintResult(int[,] numbers)
    {
        int[] sums = SumRows(numbers);
        int minIndex = MinIndex(sums);
        Console.WriteLine("Минимальная сумма: " + sums[minIndex]);
    }
}

// Класс для запуска программы
class Answer
{
    public static void Main(string[] args)
    {
        int[,] numbers;

        if (args.Length >= 1)
        {
            // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            numbers = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        numbers[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при разборе элемента {rowElements[j]} в целое число.");
                        return;
                    }
                }
            }
        }
        else
        {
            // Если аргументов на входе нет, используем примерный массив

            numbers = new int[,] {
{1, 2, 3},
{1, 1, 0},
{7, 8, 2},
{9, 10, 11}
};
        }

        UserInputToCompileForTest.PrintResult(numbers);
    }
}