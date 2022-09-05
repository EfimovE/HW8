// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя 
// индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[]CreateArrayInt (int size)  // объект для создания неповторяющегося одномерного массива
{
    int[]array = new int [size];
    Random rnd = new Random();
    for (int i = 0; i < size - 1;)
    {
  
        bool check = false;
        int tmp = rnd.Next(10, 100);
        int k;
        for (k = 0; k < i; k++)
        {
            // tmp = rnd.Next(10,20);
            if (array[k] == tmp) 
            {
                check = true;
                break;
            }
        }
        if (!check)
        {
            array[k] = tmp;
            i++;
        }
        // array[-1] = rnd.Next(10,100);
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

int[, ,] CreateMatrix3DInt (int [] array, int x, int y, int z) // Метод создания трехмерного массива.
{
    int[, ,] matrix = new int [x, y, z];
    int k = 0; 
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength (1); j++)
        {
            
            for (int ind = 0; ind < matrix.GetLength(2); ind++)
            {

                matrix[i , j , ind] = array[k];
                k++;
                
            }
        }
    }
    return matrix;
}
void PrintMatrix3D (int [, ,] matrix3D)      // Метод для вывода в консоль трехмерного массива.
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int ind = 0; ind < matrix3D.GetLength (2); ind++)
            {
                Console.Write ($"{matrix3D [i,j,ind], 3} -> ({i},{j},{ind}) ");
            }
            Console.WriteLine ();

        }
    }
}
Console.WriteLine("Введите размер Х для трехмерного массива и нажмите Enter.");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер Y для трехмерного массива и нажмите Enter.");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер Z для трехмерного массива и нажмите Enter.");
int z = Convert.ToInt32(Console.ReadLine());

int[]arr = CreateArrayInt (x*y*z + 1);
PrintArray(arr);
int[, ,] matr3D = CreateMatrix3DInt (arr, x, y, z);
PrintMatrix3D (matr3D);
