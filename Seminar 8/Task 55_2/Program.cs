/* Задача 55: Решение 2. Задайте двумерный массив. 
Напишите программу, которая заменяет 
строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя. */

int[,] FillRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Clear();

int m = new Random().Next(3, 4);
int n = new Random().Next(3, 4);

int[,] array = FillRandomArray(m, n);

int[,] ChangeArray(int[,] array)
{
    int[,] result = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            result[j, i] = array[i, j];
        }
    }

    return result;
}

/* {
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    
    for (int i = 0; i < rows; i++)
    {
        for (int j = i; j < columns; j++)
        {
            (array[i,j], array[j,i]) = (array[j,i], array[i,j]);
        }
    }
}
 */
int [,] resultArray = ChangeArray (array);

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(resultArray[i, j] + " ");
    }
    Console.WriteLine();
}