/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToDouble(new Random().Next(100, 1000)) / 100;
    }
}

void PrintArray(double[] array)
{
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write("; ");
        }
    }
    Console.WriteLine("]");
}


Console.Clear();

Console.Write("Введите количество цифр в массиве:  ");

int size = Convert.ToInt32(Console.ReadLine());

double[] array = new double[size];

FillArrayRandomNumbers(array);

Console.Write("Массив вещественных чисел: ");

PrintArray(array);

/* double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
} */

double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

Console.WriteLine($"Всего в массиве {array.Length} чисел (-ла, -ло). Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");