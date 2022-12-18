/* Задача 49: Задайте двумерный массив. Найдите элементы,
у которых оба индекса чётные, и замените эти элементы на их квадраты. 
Например, изначально массив
выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4

Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
*/

Console.Write("Введите М (строки): ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N (столбцы): ");
int n = Convert.ToInt32(Console.ReadLine());


int[,] array = new int[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(1, 11);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

void Chet (int [,] array)
{
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            array[i, j] = array[i, j] * array[i, j];
        }
    }
}
}

Chet(array);

Console.WriteLine();

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}