// Задача 58: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// // =========================================================================
Console.Clear();
// ============================================================================
void Main()
{
    int row1 = ReadInt("Введите кол-во строк Первой матрицы: ");
    int col1 = ReadInt("Введите кол-во столбцов Первой матрицы: ");
    int[,] matrix1 = FillMatrix(row1, col1, 0, 9);
    System.Console.WriteLine();
    int row2 = ReadInt("Введите кол-во строк Второй матрицы: ");
    int col2 = ReadInt("Введите кол-во столбцов Второй матрицы: ");
    int[,] matrix2 = FillMatrix(row2, col2, 0, 9);
    // ------------------------ Проверка + Вывод --------------------------
    if (row1 == col2)
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"Первая матрица: ");
        PrintMatrix(matrix1);
        System.Console.WriteLine();
        System.Console.WriteLine($"Вторая матрица: ");
        PrintMatrix(matrix2);
        System.Console.WriteLine();

        int[,] resultMatrix = TaskMathod(matrix1, matrix2);
        System.Console.WriteLine($"Произведение Первой и Второй матрицы: ");
        PrintMatrix(resultMatrix);
        System.Console.WriteLine();
    }
    else
    {
        System.Console.WriteLine();
        System.Console.WriteLine($"ОШИБКА !!! Кол-во строк Первой матрицы != кол-ву столбцов Второй матрицы");
        System.Console.WriteLine();
    }

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

int[,] TaskMathod(int[,] tMatrix1, int[,] tMatrix2)
{
    int row1 = tMatrix1.GetLength(0);
    int col1 = tMatrix1.GetLength(1);
    int row2 = tMatrix2.GetLength(0);
    int col2 = tMatrix2.GetLength(1);

    int[,] muitMatrix = new int[row1, col2];

    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
            int mult = 0;
            for (int k = 0; k < col1; k++)
            {
                mult += tMatrix1[i, k] * tMatrix2[k, j];
            }
            muitMatrix[i, j] = mult;
        }
    }

    return muitMatrix;
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
