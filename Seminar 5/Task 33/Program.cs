/* Задача 33: Задайте массив. Напишите программу, которая определяет,
присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, 3] -> да */


Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] array = new int[5] { 6, 7, 19, 345, 3 };

bool variable = false;

for (int i = 0; i < array.Length; i++)
{
    if (variable == false && array[i] == num)
    {
        /*  Console.Write("true"); */
        variable = true;
    }
}

Console.Write(variable);
