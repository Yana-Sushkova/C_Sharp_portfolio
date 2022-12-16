/* Задача 18: Напишите программу, которая по заданному номеру 
четверти, показывает диапазон возможных координат точек в этой 
четверти (x и y) */

/* WriteLine метод, а в () аргументы, методы позволяют 
нам выделить какое-то дествие в отдельную программку, 
которую можно отдельно вызывать по имени*/

// <Возвращаемый тип> <Наименование метода> (переменные) {тело метода}


// 

/* void GetXYArea(int chetvert)
{

    if (chetvert == 1)
    {
        Console.WriteLine("cordX> 0 && cordY > 0 ");
    }
    if (chetvert == 2)
    {
        Console.WriteLine("cordX < 0 && cordY > 0 ");
    }

    if (chetvert == 3)
    {
        Console.WriteLine("cordX < 0 && cordY < 0 ");
    }

    if (chetvert == 4)
    {
        Console.WriteLine("cordX > 0 && cordY < 0");
    }

}

Console.WriteLine("Введи четверть: ");
int chetvert = Convert.ToInt32(Console.ReadLine());

GetXYArea (chetvert); */

string GetXYArea(int chetvert)
{

    if (chetvert == 1)
    {
        return "cordX> 0 && cordY > 0 ";
    }
    if (chetvert == 2)
    {
       return"cordX < 0 && cordY > 0 ";
    }

    if (chetvert == 3)
    {
        return"cordX < 0 && cordY < 0 ";
    }

    if (chetvert == 4)
    {
       return"cordX > 0 && cordY < 0";
    }
return "такой четверти нет";
}

Console.WriteLine("Введи четверть: ");
int chetvert = Convert.ToInt32(Console.ReadLine());

string rezult = GetXYArea (chetvert);
/* Console.WriteLine (GetXYArea (chetvert)); */
Console.WriteLine (rezult);