/* Задача 35: Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 */


// Решить с помощью метода

int[] array = new int[123];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 124);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.WriteLine(Findcount(10, 99, array));

int Findcount(int min, int max, int[] array)
{
    int count=0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (min <= array[i] && max >= array[i])
        {
            count++;
        }
    }
    return count;
}
