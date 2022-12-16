/* Задача No17. Напишите программу, которая
принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
плоскости, в которой находится эта точка.

WriteLine метод, а в () аргументы, методы позволяют 
нам выделить какое-то действие в отдельную программку, 
которую можно отдельно вызывать по имени*/

// <Возвращаемый тип> <Наименование метода> (переменные) {тело метода}


// Получить номер четверти на плоскости

void GetPointArea(int cordX, int cordY)
{
    
    if (cordX > 0 && cordY > 0)
    {
        Console.WriteLine("1 плоскость");
        return;
    }
    if (cordX < 0 && cordY > 0)
    {
         Console.WriteLine("2 плоскость");
         return;
    }
    if (cordX < 0 && cordY < 0)
    {
         Console.WriteLine("3 плоскость");
         return;
    }
    if (cordX > 0 && cordY < 0)
    {
         Console.WriteLine("4 плоскость");
         return;
    }
Console.WriteLine("0");

}


Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

GetPointArea(x, y);


