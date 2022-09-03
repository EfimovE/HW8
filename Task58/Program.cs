// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateMatrixRndInt (int row, int col, int min, int max) // Метод создания двумерного массива.
{
    int[,] matrix = new int [row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            matrix[i , j] = rnd.Next (min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int [,] matrix)      // Метод для вывода в консоль двумерного массива.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write (" [ ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write ($"{matrix [i,j], 3}, ");
            else Console.Write($"{matrix [i,j],3}");
        }
        Console.WriteLine (" ] ");
    }
}

int[,] MultiplyMatrix (int[,] array1, int[,] array2) // Метод для умножения двух матриц.
{
    int[,] matrixResult = new int [array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength (0); j++)
        {
            for (int index = 0; index < array2.GetLength(1); index++)
                    {
                        matrixResult[i, index] += array1[i, j] * array2[j, index];
                    }
        }
    }
    return matrixResult;
}

Console.WriteLine("Введите количество строк 1-ого массива и количество столбцов 2-ого массива и нажмите Enter.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов 1-ого массива и количество строк 2-ого массива и нажмите Enter.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента 1-ого массива и нажмите Enter.");
int minElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента 1-ого массива и нажмите Enter.");
int maxElem = Convert.ToInt32(Console.ReadLine());
int [,] array2D = CreateMatrixRndInt (m, n, minElem, maxElem);
Console.WriteLine("Введите минимальное значение элемента 2-ого массива и нажмите Enter.");
int minElem2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента 2-ого массива и нажмите Enter.");
int maxElem2 = Convert.ToInt32(Console.ReadLine());
int [,] arr2D = CreateMatrixRndInt (n, m, minElem2, maxElem2);
Console.WriteLine("Даны 2 матрицы:");
PrintMatrix (array2D);
Console.WriteLine("------------------------------");
PrintMatrix (arr2D);
Console.WriteLine("Результирующая матрица будет:");
int [,] resultArray2D = MultiplyMatrix (array2D, arr2D);
PrintMatrix (resultArray2D);

