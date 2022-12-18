/* Задача 63: Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6" */

int FactorialN(int n)
{
    if (n == 1)
    {
        return 1;
    }
    Console.Write(n+", ");
    return FactorialN(n - 1);
}

Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());

int factorialN = FactorialN(n);
Console.WriteLine(factorialN);
