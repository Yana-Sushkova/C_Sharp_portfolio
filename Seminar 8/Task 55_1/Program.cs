/* Задача 55: Задайте двумерный массив. 
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

void ChangeArray(int[,] array)
{
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

ChangeArray (array);

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}