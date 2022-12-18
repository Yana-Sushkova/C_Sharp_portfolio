/* Задача 37: Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21 */

// без использования метода. Проверить количество четное или не четное.

//int[] array = new int[5] { 1, 2, 3, 4, 5 };

int[] array = new int[4] {6, 7, 3, 6};

int len = array.Length / 2;

if (array.Length % 2 == 1)
{
    len++;
}

int[] newarray = new int[len];
int end = array.Length - 1;
int start = 0;
for (int i = 0; i < len; i++)
{
    if (start + i != end - i)
    {
        newarray[i] = array[i] * array[end - i];
    }
    else { newarray[i] = array[i]; }
}

for (int i = 0; i < newarray.Length; i++)
{
    Console.Write(newarray[i] + " ");
}

