// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки 
// с наименьшей суммой элементов: 1 строка


int[,] FillMatrix(int row, int column, int leftRange, int rightRange) 
{
    var matrix = new int[row, column];
    var rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}

void PrintMatrix(int[, ] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int FindMinSumRow(int[, ] matrix)
{
    int? minSum = null;
    int minSumRow = 0;
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        if (minSum == null)
        {
            minSum = sum;
        }
        if (sum < minSum) {
            minSum = sum;
            minSumRow = i;
        }
    }
    return minSumRow + 1;  // Согласно приведенному примеру в условии, нумерация строк идет от 1, поэтому вывожу индекс строки + 1
}

var matrix = FillMatrix(4, 4, -9, 10);
PrintMatrix(matrix);
System.Console.WriteLine($"Строка с наименьшей суммой элементов - {FindMinSumRow(matrix)} строка.");