/* Задача 67: Напишите программу, которая будет принимать 
на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumRec(int number, int currentSum)
{
if (number > 9) 
{
    //currentSum+=number%10;
    //int temp = number/10; 
    return SumRec(number/10, currentSum+number%10);
}
else return currentSum+number;
}
Console.WriteLine(SumRec(number, 0));
