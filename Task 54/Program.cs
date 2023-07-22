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
// =========================================================================
Console.Clear();
// =========================================================================
void Main()
{
    int row = ReadInt("Введите кол-во строк: ");
    int col = ReadInt("Введите кол-во столбцов: ");
    int[,] matrix = FillMatrix(row, col, 0, 9);
    System.Console.WriteLine();
    PrintMatrix(matrix);
    System.Console.WriteLine();
    TaskMathod(matrix);
    PrintMatrix(matrix);
    System.Console.WriteLine();
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] fMatrix = new int[row, col];
    Random rand = new Random();

    for (int i = 0; i < fMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < fMatrix.GetLength(1); j++)
        {
            fMatrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return fMatrix;
}

void TaskMathod(int[,] tMatrix)
{
    int rows = tMatrix.GetLength(0);
    int columns = tMatrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            for (int k = 0; k < columns - j - 1; k++)
            {
                if (tMatrix[i, k] < tMatrix[i, k + 1])
                {
                    int countMatrix = tMatrix[i, k];
                    tMatrix[i, k] = tMatrix[i, k + 1];
                    tMatrix[i, k + 1] = countMatrix;
                }
            }
        }
    }
}

void PrintMatrix(int[,] pMatrix)
{
    for (int i = 0; i < pMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < pMatrix.GetLength(1); j++)
        {
            System.Console.Write(pMatrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

Main();