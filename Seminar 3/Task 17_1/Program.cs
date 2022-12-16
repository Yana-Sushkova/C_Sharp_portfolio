/* Задача No17. Напишите программу, которая
принимает на вход координаты точки (X и Y),
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти
плоскости, в которой находится эта точка.

WriteLine метод, а в () аргументы, методы позволяют 
нам выделить какое-то действие в отдельную программку, 
которую можно отдельно вызывать по имени*/

// <Возвращаемый тип> <Наименование метода> (переменные) {тело метода}


// Получить номер четверти на плоскости
int GetPointArea(int cordX, int cordY)
{
    int numberArea = 0;
    if (cordX > 0 && cordY > 0)
    {
        numberArea = 1;
    }
    if (cordX < 0 && cordY > 0)
    {
        numberArea = 2;
    }
    if (cordX < 0 && cordY < 0)
    {
        numberArea = 3;
    }
    if (cordX > 0 && cordY < 0)
    {
        numberArea = 4;
    }
return numberArea;
}


Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int numberArea = GetPointArea(x, y);

Console.WriteLine(numberArea);


