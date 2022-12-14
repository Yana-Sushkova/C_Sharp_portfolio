/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Clear();

// Делаем запрос числа у Пользователя.
Console.WriteLine("Введите пятизначное число: ");
int number5z = Convert.ToInt32(Console.ReadLine());

// Если число не пятизначное, повторно просим ввести имненно пятизначное число.
while (number5z < 10000 || number5z > 99999)
{
    Console.WriteLine("Введенное число НЕ пятизначное, введите пятизначное число (отрицательные и дробные числа не допускаются):");
    number5z = Convert.ToInt32(Console.ReadLine());
}

string str = number5z.ToString();

void CheckingNumber(string str) // метод (подпрограмма)
{
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine($"{number5z} - Да, палиндром.");
    }
    else
    {
        Console.WriteLine($"{number5z} - Нет, НЕ палиндром.");
    }
}

CheckingNumber(str);
