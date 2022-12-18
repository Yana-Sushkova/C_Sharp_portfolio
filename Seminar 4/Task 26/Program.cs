/* int number = 123454;
string strNumber = Math.Abs (number).ToString();
Console.WriteLine (strNumber.Length); */

/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

int GetQuantity (int number)
{
string strNumber = Math.Abs (number).ToString();
int Length = strNumber.Length;
return Length;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = GetQuantity(num);
Console.WriteLine(num1);

Console.WriteLine (GetQuantity(num));