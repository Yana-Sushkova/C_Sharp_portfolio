/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 ??? неверный пример*/

void PrintArray(int[] array)
{
    Console.Write("Ввведенные числа: ");
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

Console.WriteLine("Сколько чисел вы хотите ввести?  ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Введите число под номером {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

PrintArray(array);

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine();
Console.WriteLine($"Количество значений больше 0 = {count}");
