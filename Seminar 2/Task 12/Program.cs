﻿/* 12. Напишите программу, которая будет принимать 
на вход два числа и выводить, является ли второе число 
кратным первому. Если число 2 не кратно числу 1, то 
программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
 */

Console.Clear();

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int b = Convert.ToInt32(Console.ReadLine());

/* int result = a % b;
//Console.Write(result);

if (result == 0)
{
    Console.WriteLine("число кратно");
}
else
{
    Console.WriteLine($"число не кратно {result}");
}
 */

if (a % b == 0)
{
    Console.WriteLine("число кратно");
}
else
{
    Console.WriteLine($"число не кратно, остаток {a % b}");
}

