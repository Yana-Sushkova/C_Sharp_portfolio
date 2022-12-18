/* Задача 57: Составить частотный словарь
элементов двумерного массива. Частотный
словарь содержит информацию о том, сколько 
раз встречается элемент входных данных. */

int[] array = new int[10] { 1, 1, 4, 5, 2, 8, 5, 4, 2, 4 };
Dictionary<int, int> dict = new Dictionary<int, int>(); // пока пустой словарь
for (int i = 0; i < array.Length; i++)
{
    if (!dict.ContainsKey(array[i]))
    {
        dict.Add(array[i],1);
    }
    else
    {
dict[array[i]]++;
    }
}

foreach (var dic in dict)
{
    Console.WriteLine($"{dic.Key} встречается {dic.Value} раз");
}
