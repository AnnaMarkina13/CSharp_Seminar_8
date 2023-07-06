// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

bool CanProductMatrix(int[, ] matrix1, int[, ] matrix2)
{
    if ((matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1))
        || (matrix1.GetLength(1) == matrix2.GetLength(0)))
    {
        return true;
    }
    System.Console.WriteLine("Невозможно вычислить произведение данных матриц!");
    return false;
}

int[, ] InitProdMatrix(int[, ] matrix1, int[, ] matrix2)
{
    int[, ] prodMatrix;
    if (matrix1.GetLength(0) == matrix2.GetLength(0) && matrix1.GetLength(1) == matrix2.GetLength(1)) 
    {
        prodMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
    }
    else
    {
        prodMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    }
    return prodMatrix;
}

int[, ] ProductMatrix(int[, ] matrix1, int[, ] matrix2, int[, ] prodMatrix)
{
    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        int sum = 0;
        for (int j = 0; j < matrix2.GetLength(1); j++) 
        {
            for (int k = 0; k < matrix1.GetLength(0); k++) 
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            prodMatrix[i, j] = sum;
            sum = 0;
        }
    }
    return prodMatrix;
}

int rows1 = ReadInt("Введите количество строк для 1 матрицы: ");
int cols1 = ReadInt("Введите количество столбцов для 1 матрицы: ");
var matrix1 = FillMatrix(rows1, cols1, -9, 10);

int rows2 = ReadInt("Введите количество строк для 2 матрицы: ");
int cols2 = ReadInt("Введите количество столбцов для 2 матрицы: ");
var matrix2 = FillMatrix(rows2, cols2, -9, 10);

PrintMatrix(matrix1);
System.Console.WriteLine();
PrintMatrix(matrix2);
System.Console.WriteLine();

if (CanProductMatrix(matrix1, matrix2))
{
    var prodMatrix = ProductMatrix(matrix1, matrix2, InitProdMatrix(matrix1, matrix2));
    System.Console.WriteLine("Результирующая матрица, полученная путем произведения двух предыдущих: ");
    PrintMatrix(prodMatrix);
}


