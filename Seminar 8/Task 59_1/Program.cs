/* Задача 59: Решение 1. Задайте двумерный массив из целых чисел. 
Напишите программу, которая запишет нулями строку и 
столбец, на пересечении которых расположен наименьший 
элемент массива.
Например, задан массив:
4 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
0 0 0 0
0 9 4 2
0 2 2 6
0 3 4 7 */

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
void GetMinZero(int[,] array)
{
int min = int.MaxValue;
int indexminrow=0;
int indexmincolumn=0;

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min>array[i,j])
            {
                min = array[i,j];
                indexminrow = i;
                indexmincolumn = j;
            }
        }
     }
for (int i = 0; i < array.GetLength(0); i++)
{
    array[i,indexmincolumn]=0;
}
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
{
    array[indexminrow,j]=0;
}
}

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Clear();

int m = new Random().Next(3, 4);
int n = new Random().Next(3, 4);

int[,] array = FillRandomArray(m, n);

GetMinZero(array);

Console.WriteLine();

PrintArray(array);



