// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// (Округление до 2х знаков - Math.Round(value, 2))


int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int[,] CreateArray(int n, int m, int min, int max)
{
    int[,] array = new int[n, m];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            Console.Write($"{array[row, col]} ");
        }
        Console.WriteLine();
    }
}

int n = PrintAndGetValue("Введите количество строк ");
int m = PrintAndGetValue("Введите количество столбцов ");
int min = PrintAndGetValue("Введите минимальное значение элементов массива ");
int max = PrintAndGetValue("Введите максимальное значение элементов массива ");
Console.WriteLine();

int[,] array = CreateArray(n, m, min, max);
PrintArray(array);


double[] sum = new double[m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        sum[i] += array[j, i];
    }
}

Console.WriteLine("Среднее арифметическое каждого столбца: " );

for (int i = 0; i < m; i++)
{
    Console.Write(Math.Round((sum[i] / n),2) + " ");
}

