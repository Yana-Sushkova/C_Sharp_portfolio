/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.Clear();

double Pow2(int param1, int param2) // метод (подпрограмма)
{
    return Math.Pow((param2 - param1), 2);
}

double Distance(int x1, int x2, int y1, int y2, int z1, int z2) // метод (подпрограмма)
{
    return Math.Sqrt(Pow2(x1, x2) + Pow2(y1, y2) + Pow2(z1, z2));
}

// Запрос у Пользователя
Console.WriteLine("Введите координаты первой точки (отдельно в строке, после каждого ввода нажимая enter) X1, Y1, Z1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (отдельно в строке, после каждого ввода нажимая enter) X2, Y2, Z2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Distance(x1, x2, y1, y2, z1, z2);

Console.WriteLine(result);