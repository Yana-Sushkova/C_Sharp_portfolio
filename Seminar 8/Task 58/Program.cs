/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Clear();

Console.WriteLine("Введите размеры матриц:");
int row1Matrix = ReadInt("Введите число строк 1-й матрицы: ");
int column1Row2Matrix = ReadInt("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int column2Matrix = ReadInt("Введите число столбцов 2-й матрицы: ");

Console.WriteLine($"Первая матрица:");
int[,] firstMartrix = FillRandomArray(row1Matrix, column1Row2Matrix);

Console.WriteLine();

Console.WriteLine($"Вторая матрица:");
int[,] secondMartrix = FillRandomArray(column1Row2Matrix, column2Matrix);

Console.WriteLine();

int[,] resultMatrix = new int[row1Matrix, column2Matrix];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);

Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(resultMatrix);

// Метод считывающи целое число от пользователя
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Метод находящий произведение двух матриц
void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secondMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

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

//  Метод вывода двумерного массива в терминал
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