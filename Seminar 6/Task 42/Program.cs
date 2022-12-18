/* Задача 42: Напишите программу, которая будет 
преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10 */

string ConvertToBin(int value)
{
    string result = null;
    while (value != 0)
    {
        result=Convert.ToString(value % 2)+result;
        value = value/2;
    }
return result;
}

Console.WriteLine("Введите десятичное: ");
int value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(ConvertToBin(value));