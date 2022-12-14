/* Задача 43: Напишите программу, которая найдёт точку
 пересечения двух прямых, заданных уравнениями 
 y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

Console.Clear();

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine()); //Var-это неявный тип, который означает, что система сама определит тип данных
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());

if ((k1 == k2) && (b1 == b2))
{
    Console.Write("Прямые совпадают");
}

else if (k1 == k2)
{
    Console.Write("Прямые параллельны");
}

else if (k1 != k2)
{
    var x = (b2 - b1) / (k1 - k2);
    var y = k2 * x + b2;
    x = Math.Round(x, 3);//округление
    y = Math.Round(y, 3);
    Console.WriteLine($"Пересечение в точке: (х={x};y={y})");
}



