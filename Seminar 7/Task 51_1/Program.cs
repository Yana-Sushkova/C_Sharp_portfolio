﻿/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, 
находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д. 
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
*/

Console.Write("Введите количество строк/столбцов в квадратном массиве: ");
int m = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, m];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        array[i, j] = new Random().Next(1, 11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int DiagonalSum (int [,] array)
{
    int sum=0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (i == j)
        {
            sum=sum+array[i,j];
        }
    }
}
return sum;
} 

Console.WriteLine();

Console.WriteLine($"Сумма элементов главной диагонали: {DiagonalSum(array)}");
