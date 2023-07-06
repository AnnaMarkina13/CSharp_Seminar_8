// Задача 60. ...Сформируйте трёхмерный массив из двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[, , ] Fill3DArray(int x, int y, int z, int leftRange, int rightRange) 
{
    var array3D = new int[x, y, z];
    var rand = new Random();

    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = rand.Next(leftRange, rightRange);
            }
        }
    }
    return array3D;
}

void Print3DArray(int[, , ] array3D) 
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                System.Console.Write($"{array3D[i, j, k]}({i},{j},{k})\t");
            }
            System.Console.WriteLine();
        }
    }
}


int x = ReadInt("Введите первый размер трехмерного массива: ");
int y = ReadInt("Введите второй размер трехмерного массива: ");
int z = ReadInt("Введите третий размер трехмерного массива: ");
var arr3D = Fill3DArray(x, y, z, 10, 100);
Print3DArray(arr3D);