/* Задача 52. Решение 2. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждой строки.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int [,] array = new int[10,10];
for (int i = 0; i < array.GetLength (0); i++)
{
    double tempValue = 0;
    for (int j = 0; j < array.GetLength (1); j++)
    {
        array[i,j]=new Random().Next(1,6);
        Console.WriteLine(array[i,j]+ " ");
        tempValue=tempValue+array[i,j];

    }
    Console.Write($"Ср.ар.строки = {tempValue/array.GetLength (1)}");
    Console.WriteLine();
}

