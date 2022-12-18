/* Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

Console.WriteLine("Введите количество нужных чисел Фибоначчи");
int Num = Convert.ToInt32(Console.ReadLine());
int[] res = new int[Num];
if (Num == 0) Console.WriteLine("Ну и не будет тебе Фибоначчи");
else
{
    res[0] = 0;
    if (Num == 1) Console.WriteLine("Ну и получи свой 0");
    else
    {
        res[1] = 1;
        if (Num > 1)
        {
            for (int i = 2; i < Num; i++)
            {
                res[i] = res[i - 1] + res[i - 2];
            }

            Console.WriteLine();
            for (int i = 0; i < res.Length; i++)
            {
                Console.Write(res[i] + " ");
            }
        }
    }
}
