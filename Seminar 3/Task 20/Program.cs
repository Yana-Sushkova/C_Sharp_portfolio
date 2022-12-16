/* Задача 21: Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

double Distance(int x1, int x2, int y1, int y2)
{
    double result = 0;
    result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return result;
}

Console.WriteLine("Введите координаты первой точки X1, Y1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки X2, Y2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, x2, y1, y2);

Console.WriteLine(Math.Round (result, 2));
