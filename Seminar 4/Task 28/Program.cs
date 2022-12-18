/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
 */

int GetFl(int number)
{
    int res = 1;

       for (int i = 1; i <= number; i++)
    {
        res = res * i;
    }

    return res;
}

Console.WriteLine("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(GetFl(number));