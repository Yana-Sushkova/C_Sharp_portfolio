/* Задача 65: Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 5, 6, 7, 8" */

string NumbersRec(int M, int N)
{
    if (M <= N) 
    {
        return NumbersRec(M, N -1) + $"{N} ";
    }
    else return String.Empty;
}
Console.Write("Write M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Write N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumbersRec(M, N));
