/* Задача 52. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для поиска ср. арифметического значения каждого столбца.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

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

void GetAverage(int[,] array, int m, int n)
{
    for (int i = 0; i < n; i++)
    {
        int sum = 0;
        for (int j = 0; j < m; j++)
        {
            sum = sum + array[j, i];
        }
        double average = sum / (double)m;
        double averageRound = Math.Round(average, 1);
        Console.WriteLine($"Среднее арифметическое столбца № {i + 1}: {averageRound}");
    }
}
Console.Clear();

Console.Write("Введите М (строки): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N (столбцы): ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillRandomArray(m, n);

GetAverage(array, m, n);
