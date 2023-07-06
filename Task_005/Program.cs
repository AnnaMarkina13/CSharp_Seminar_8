// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SpiralFillMatrix(int[, ] matrix, int row, int col, int i)
{
    matrix[row, col] = i;
    if (col < matrix.GetLength(1) - 1 && (matrix[row, col + 1] == 0) && (row == 0 || matrix[row - 1, col] != 0)) 
    {
        SpiralFillMatrix(matrix, row, col + 1, ++i);
    } 
    else if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] == 0)
    {
        SpiralFillMatrix(matrix, row + 1, col, ++i);
    }
    else if (col > 0 && matrix[row, col - 1] == 0)
    {
        SpiralFillMatrix(matrix, row, col - 1, ++i);
    }
    else if (row > 0 && matrix[row - 1, col] == 0)
    {
        SpiralFillMatrix(matrix, row - 1, col, ++i);
    }
}

void PrintMatrix(int[, ] matrix) 
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < 10) 
                System.Console.Write("0" + matrix[i, j] + "\t");
            else 
                System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int row = ReadInt("Введите количество строк в матрице: ");
int col = ReadInt("Введите количество столбцов в матрице: ");
int[, ] matrix = new int[row, col];
SpiralFillMatrix(matrix, 0, 0, 1);
PrintMatrix(matrix);