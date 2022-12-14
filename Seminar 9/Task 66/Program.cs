/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetSumMtoN(int sum, int temp, int n)
{
    if (temp <= n)
    {
        sum += temp;
        temp += 1;
        return GetSumMtoN(sum, temp, n);
    }
    else return sum;
}

Console.Write("Write M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Write N: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetSumMtoN(0, m, n));