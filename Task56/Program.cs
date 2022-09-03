// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

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

int [] ArrayofSumRow (int [,] array2D)
{
    int [] array = new int [array2D.GetLength(0)];
    int sumRow = 0;
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            sumRow += array2D[i , j];

        }
        array [i] = sumRow;
        sumRow = 0;
    }
    return array;
}
void PrintArray (int[]array) // метод для вывода в консоль
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine($"{array[array.Length-1]} ]");
}

void NumberMinRow (int[]array)
{
    int indexMinEl = 0;
    int minEl = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minEl)
        {
            indexMinEl = i;
            minEl = array[i]; 
        } 
    }
    Console.WriteLine($"{indexMinEl + 1} строка.");
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
int[]arr = ArrayofSumRow (array2D);
PrintArray(arr);
NumberMinRow(arr);