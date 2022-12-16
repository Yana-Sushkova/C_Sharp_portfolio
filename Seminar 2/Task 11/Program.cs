/* 11. Напишите программу, которая выводит 
случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98*/

Console.Clear();

//Случайное число
int number = new Random().Next(100, 999);
int a1 = number / 100;
int a2 = number % 10;

Console.WriteLine(number);
int result = a1 * 10 + a2;
Console.Write(result);

