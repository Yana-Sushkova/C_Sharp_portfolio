/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Для решения задания использование цикла for является обязательным условием
452 -> 11
82 -> 10
9012 -> 12 */

// Находим количество цифр в числе
int GetQuantity(int num)
{
    string strNumber = Math.Abs(num).ToString();
    int Length = strNumber.Length;
    return Length;
}
// Находим сумму цифр в числе
void SumNumbers(int num, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += num % 10; // Оператор присваивания сложения (+=) sum += num % 10 эквивалентно sum=sum+num % 10. 
        //% (по модулю) - это математический оператор, который возвращает остаток после вычисления 
        //- извлечение последней цифры числа для целых чисел
        num /= 10; // Оператор присваивания деления num /= 10 эквивалентно num=num/10
    }
    Console.WriteLine(sum);
}


Console.Clear();

Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

int len = GetQuantity(num);

SumNumbers(num, len);