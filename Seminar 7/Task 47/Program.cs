/* Задача 47. Запросите от пользователя размерности двумерного массива. 
Напишите метод для заполнения массива случайными числами. 
Напишите метод для вывода массива на экран (постарайтесь вывести
 массив красиво). Округлите значения, генерируемые Random до 
 двух знаков после запятой.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

double[,] FillRandomArray(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 100;
            Console.Write(array[i, j] + "  ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Clear();

Console.Write("Введите количество строк в массиве M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве N: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = FillRandomArray(m, n);