/* Задача 39: Напишите программу, которая перевернёт 
одномерный массив (последний элемент будет на первом 
месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6] */

void PrintArray(int[] array)
{
    Console.Write("Массив: ");
    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int []array = new int[10] {1,2,3,4,5,6,7,8,9,10};

for (int i = 0; i < array.Length/2; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1)-i];
    array[(array.Length-1)-i] = temp;
}

PrintArray(array);