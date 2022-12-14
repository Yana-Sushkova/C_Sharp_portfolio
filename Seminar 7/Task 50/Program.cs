/* Задача 50. Напишите программу, которая будет принимать от
 пользователя позицию (M, N) двумерного массива и возвращать 
 значение элемента, стоящего в этой позиции. Если такой 
 позиции в массиве нет, то сообщить об этом пользователю.
 Сгенерировать массив случайным образом. Размерность массива
 определить самостоятельно. Использование методов для заполнения
 массива обязательно. Остальное можно реализовать в главной программе.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
M = 1, N = 7 -> В массиве отсутствует элемент в такой позиции. */

int[,] FillRandomArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(1, 100);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

Console.Clear();

int m = new Random().Next(2, 10);
int n = new Random().Next(2, 10);

int[,] array = FillRandomArray(m, n);

Console.WriteLine("Введите позицию двумерного массива (сперва строка, затем столбец)");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > m && b > n)
    Console.WriteLine("В массиве отсутствует элемент в такой позиции");
else
{
    int c = array[a, b];
    Console.WriteLine(c);
}