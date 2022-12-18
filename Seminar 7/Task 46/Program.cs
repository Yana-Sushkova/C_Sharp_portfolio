/* Задача 46: Задайте двумерный массив размером m×n, 
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
Прерва столбцы потом строки */

Console.Write("Введите М: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];
/* {
    { 1, 2, 5, 3, 5 },
    { 1, 2, 5, 3, 5 },
    { 1, 2, 5, 3, 5 },
    { 1, 2, 5, 3, 5 },
    { 1, 2, 5, 3, 5 }

};  */

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j]=new Random().Next(1,100);
        Console.Write(array[i,j]+" ");
    }
     Console.WriteLine();
}
