// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9
// (Округление до 2х знаков после запятой - Math.Round(value, 2))


int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

bool IsNumberValid(int number)
{
    if (number <= 0)
        return false;
    return true;
}

double[,] CreateArray(int n, int m)
{
    double[,] array = new double[n, m];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int col = 0; col < array.GetLength(1); col++)
        {
            array[row, col] = Math.Round(new Random().NextDouble() * 100, 2);
        }
    }
    return array;
}

void PrintArray(double[,] array)
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


double[,] a = CreateArray(n, m);
PrintArray(a);