// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и
// выдаёт номер строки с наименьшей суммой элементов: 1 строка
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
    //---------------------------------------------
    int minRow = 0;
    int minSum = TaskMathod(matrix, 0);

    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        int sum = TaskMathod(matrix, i);
        if (sum < minSum)
        {
            minRow = i;
            minSum = sum;
        }
    }
    System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRow + 1} строка");
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

int TaskMathod(int[,] tMatrix, int row)
{
    int sum = 0;
    for (int col = 0; col < tMatrix.GetLength(1); col++)
    {
        sum += tMatrix[row, col];
    }
    return sum;
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
