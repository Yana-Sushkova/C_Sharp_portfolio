/*  Задайте двумерный массив. Напишите программу, 
 которая поменяет местами первую и последнюю 
 строку массива. */

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

int m = new Random().Next(2, 6);
int n = new Random().Next(2, 6);

int[,] array = FillRandomArray(m, n);

void Revers(int [,] array)
{
    int temp;
    for (int j = 0; j < n; j++)
    {
        temp=array[0, j];
        array[0, j]=array[m-1,j];
        array[m-1,j]=temp;
    }
}

Revers(array);

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}