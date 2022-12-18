/* Задача 44: Не используя рекурсию, выведите первые N чисел 
Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8 */

/* числа Фебаноччи
f(1) = 1
f (2) = 1
f(n) = f(n-1)+f(n-2))
 */

/* int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
} */

Console.WriteLine("Введите N: ");
int value = Convert.ToInt32(Console.ReadLine());

int[] fibo = new int[value];

fibo[0]=0;
fibo[1]=1;
Console.Write($"{fibo[0]}, ");
Console.Write($"{fibo[1]}, ");

for (int i = 2; i < fibo.Length; i++)
{
       {
    fibo[i]=fibo[i-1]+fibo[i-2];
    }
    Console.Write($"{fibo[i]}");
    
    if (i != fibo.Length - 1)
        {
            Console.Write(", ");
        }
       
}

