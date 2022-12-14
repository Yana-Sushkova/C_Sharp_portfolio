/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и 
выводит их на экран. 
Заполнение массива производит пользователь.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19] ??? в примерах не 8 элементов в массиве
6, 1, 33 -> [6, 1, 33] ??? в примерах не 8 элементов в массиве, 
ориентировалась на примеры. */
Console.Clear();

Console.WriteLine("Введите количество цифр в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

//int[] array = new int[3];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите элемент массива под номером {i}:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i != array.Length - 1)
    {
        Console.Write(", ");
    }
}

Console.Write("]");