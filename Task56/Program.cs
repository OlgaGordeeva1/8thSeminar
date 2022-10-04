// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill(int[,] array, int min, int max)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            array[row, column] = new Random().Next(min, max);
        }
    }
}

void Print(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            Console.Write($"{array[row, column],2}");
        }
        Console.WriteLine();
    }
}

void FindMin(int[,] arr)
{
    int rows = arr.GetLength(0);
    int columns = arr.GetLength(1);
    int[] sum = new int[rows];
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        { sum[row] += arr[row, column]; }
    }
    int min = sum[0];
    int indexmin = 0;
    for (int n = 0; n < rows; n++)
    {
        if (sum[n] < min)
        {
            min = sum[n];
            indexmin = n;
        }
    }
    Console.WriteLine($"Минимальная сумма чисел в {indexmin + 1}-ой строке");
}



int[,] matrix = CreateArray(4, 4);
Fill(matrix, 0, 5);
Print(matrix);
Console.WriteLine();
FindMin(matrix);
