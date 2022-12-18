/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

// тип [] название массива

/* int size = 25;

int[] array = new int[size]; */

//int[] array = new int[5] { 4, 3, 4, 5, 2 };
/* array[0]=5;

array[3] = 5+2;

array[1] = array[0]+array[3];
Console.WriteLine(array[1]);
 */
/* int[] array = new int[8];

for (int i=0; i<=7; i++) // заполняет цикл от 0 до 7
{
    array[i]=i;
}
 */

int[] array = new int[8];

/* for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(0,2);
}

for (int i=0; i<array.Length; i++) 
{
    Console.Write(array[i]+" ");
}
 */

 for (int i=0; i<array.Length; i++)
{
    array[i]=new Random().Next(0,2);
    Console.Write(array[i]+" ");
}
