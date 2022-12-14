/* Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет 
количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

Console.Clear();

Console.Write("Введите количество цифр в массиве:  ");

int size = Convert.ToInt32(Console.ReadLine());


int[] array = new int[size];

FillArrayRandomNumbers(array);

Console.Write("Массив: ");

Console.Write("[");

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]);
    if (i != array.Length - 1)
    {
        Console.Write(", ");
    }
}

Console.WriteLine("]");

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        count++;
    }
}

Console.WriteLine($"Всего в массиве {array.Length} чисел (-ла, -ло), {count} из которых чётные (-ое)");



