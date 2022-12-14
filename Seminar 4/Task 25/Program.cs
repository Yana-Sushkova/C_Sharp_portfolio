/* Задача 25: Напишите программу, которая принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B. Для решения задания использование 
цикла for является обязательным условием. Не использовать встроенный метод 
возведения в степень.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Getdegree(int a, int b)
{
    int result = a;

    for (int i = 1; i < b; i++)
    {
        result = result * a;
    }
    return result;
}


Console.Clear();
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int degree = Getdegree(a, b);
Console.WriteLine(degree);
