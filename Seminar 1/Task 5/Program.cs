﻿/* Задача 5: Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N. 
4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
2 -> " -2, -1, 0, 1, 2"*/

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int negativN = n * -1;
while(negativN <= n)
{
    Console.WriteLine(negativN);
    negativN  = negativN + 1;  
}