// Задача 0: Напишите программу которая на вход принимает число и выдает его 
//  квадрат (число умноженное само на себя)
/* Например:
4 -> 16
-3 -> 9
-7 -> 49 */

// Запрос числа от пользователя
Console.Write("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(number);

// Квадрат исходного числа

int sqrnumber = number * number;

// Вывод результата на экран

Console.WriteLine($"Квадрат вашего числа = {sqrnumber}");

// Console.WriteLine($"Квадрат вашего числа = {number * number}");

