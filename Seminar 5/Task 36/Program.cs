/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

void FillArrayRandomNumbers(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-20, 21);
    }
}

void PrintArray(int[] array)
{
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
}

Console.Clear();

Console.Write("Введите количество цифр в массиве:  ");

int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

FillArrayRandomNumbers(array);

PrintArray(array);

int sumevennumbers = 0;

for (int i = 1; i < array.Length; i += 2) //+= присваивание после сложения. Присваивает левому операнду сумму левого и правого операндов: выражение. A += B равнозначно выражению A = A + B
    {
        sumevennumbers += array[i];
    }

Console.WriteLine($"Всего в массиве {array.Length} чисел (-ла, -ло), сумма элементов cтоящих на нечётных позициях = {sumevennumbers}");
