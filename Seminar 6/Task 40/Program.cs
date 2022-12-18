/* Задача 40: Напишите программу, которая принимает на 
вход три числа и проверяет, может ли существовать 
треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона 
треугольника меньше суммы двух других сторон. */

Console.Clear();

bool TriangleChek(int[] sides)
{
    //bool result = false;
    if (sides[0] + sides[1] < sides[2] && sides[2] + sides[1] < sides[0] && sides[0] + sides[2] < sides[1])
    {
        return true;
    }

    return false;
}
int[] array = new int[3];

//Запрос у Пользователя
Console.Write("Введите сторону a: ");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону b: ");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите сторону c: ");
array[2] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(TriangleChek(array));
