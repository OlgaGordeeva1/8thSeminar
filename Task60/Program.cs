// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] CreateArray3D(int i, int j, int k)
{
    return new int[i, j, k];
}

void Fill(int[,,] array, int min, int max)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int layers = array.GetLength(2);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            for (int layer = 0; layer < layers; layer++)
            {
                array[row, column, layer] = new Random().Next(min, max);
            }
        }
    }
}

// void Check (int [,,] array)
// {
//     int rows = array.GetLength(0);
//     int columns = array.GetLength(1);
//     int layers = array.GetLength(2);
//     for (int row = 0; row < rows; row++)
//     {
//         for (int column = 0; column < columns; column++)
//         {
//             for (int layer = 0; layer < layers; layer++)
//             {
//                 for (int i=0; i<rows; i++)
//                 {
//                     if (array[i,column,layer]==)
//                 }
//             }
// }



void PrintIndex(int[,,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int layers = array.GetLength(2);
    for (int row = 0; row < rows; row++)
    {
        for (int column = 0; column < columns; column++)
        {
            for (int layer = 0; layer < layers; layer++)
            {
                Console.Write($"{array[row, column, layer],2}({row},{column},{layer}) ");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = CreateArray3D(2, 2, 2);
Fill(matrix, 10, 19);
PrintIndex(matrix);

