/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт 
номер строки с наименьшей суммой элементов: 1 строка */

Console.Clear();

int m = new Random().Next(1, 5);
int n = new Random().Next(1, 5);

int[,] array = FillRandomArray(m, n);

NumberRowMinSumElements(array);

Console.WriteLine();

//Метод заполнения двумерного массива рандомными числами с выводом в терминал
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

// Метод считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов
void NumberRowMinSumElements(int[,] array)
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;
    for (int j = 0; j < array.GetLength(1); j++) // GetLength(1) количество элементов в направлении столбца
    {
        minRow += array[0, j];
    }
    for (int i = 0; i < array.GetLength(0); i++) //GetLength(0) количество элементов в направлении строки
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRow += array[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine();
    Console.Write($"{minSumRow + 1} строка с наименьшей суммой элементов");
    Console.WriteLine();
}


