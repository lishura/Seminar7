// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 7 -> такого числа в массиве нет
// (row ,colum - входные данные)



int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

string PrintStringAndGetArray(string message)
{
    Console.WriteLine(message);
    string str = Console.ReadLine();
    return str;
}

bool IsNumberValid(int number)
{
    if (number <= 0)
        return false;
    return true;
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


int[,] array = CreateArray(n, m, 1, 20);
PrintArray(array);

string str = PrintStringAndGetArray("Введите позицию элемента в двумерном массиве через запятую");

string[] position = str.Split(",", StringSplitOptions.RemoveEmptyEntries);
int[] pos = new int[position.Length];

for (int i = 0; i < pos.Length; i++)
{
    pos[i] = int.Parse(position[i]);
}

if (pos[0] < n && pos[1] < m)
{
    for (int row = 0; row < n; row++)
    {
        for (int col = 0; col < m; col++)
        {
            if (row == pos[0] && col == pos[1])
            {
                Console.WriteLine("На заданной позиции находится элемент " + array[row, col]);
            }
        }
    }
}
else
{
    Console.WriteLine("На заданной позиции элемента нет");
}

