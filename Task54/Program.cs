// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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

int[,] SortDescendingElementRow (int [,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j++)
        {
            int tmp = 0;
            bool isAction = false;
            isAction = false;
            for (int k = 0; k < array2D.GetLength(1) - 1; k++) 
            {
                if (array2D[i, k] < array2D[i, k + 1]) 
                {
                tmp = array2D[i, k + 1];
                array2D[i, k + 1] = array2D[i, k];
                array2D[i, k] = tmp;
                isAction = true;
                }
            }
            if (!isAction) break;
        }
    }
    return array2D;
}

Console.WriteLine("Введите количество строк и нажмите Enter.");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов и нажмите Enter.");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента массива и нажмите Enter.");
int minElem = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента массива и нажмите Enter.");
int maxElem = Convert.ToInt32(Console.ReadLine());
int [,] array2D = CreateMatrixRndInt (m, n, minElem, maxElem);
PrintMatrix (array2D);
Console.WriteLine();

int [,] arr2D = SortDescendingElementRow (array2D);
PrintMatrix (arr2D);