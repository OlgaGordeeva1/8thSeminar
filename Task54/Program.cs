// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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
            Console.Write($"{array[row, column],3}");
        }
        Console.WriteLine();
    }
}

// int FindMin(int[] arr)
// {
//     int size = arr.GetLength(0);
//     int min = arr[0];
//     for (int i = 0; i < size; i++)
//     {
//         if (arr[i] < min) { min = arr[i]; }
//     }
//     return min;
// }


int[,] SortMaxMin(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
        for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            for (int n = 0; n < columns - 1; n++)
            {
                if (array[row, n] < array[row, n+1])
                {
                    int k = array[row, n+1];
                    array[row, n+1] = array[row, n];
                    array[row, n] = k;
                }
            }
        }
    }
    return array;
}

int[,] matrix = CreateArray(5, 10);
Fill(matrix, 1, 10);
Print(matrix);
Console.WriteLine();
int[,] mas = SortMaxMin(matrix);
Print(mas);


