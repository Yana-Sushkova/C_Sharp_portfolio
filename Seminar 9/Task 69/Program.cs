/* Задача 69: Напишите программу, которая на вход принимает 
два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.Write("Enter A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter B: ");
int B = Convert.ToInt32(Console.ReadLine());
int PowerRec(int A, int B)
{ return B == 0 ? 1 : PowerRec(A, B - 1) * A;
if (B == 0) return 1;
else return PowerRec(A, B - 1) * A;
}
Console.WriteLine(PowerRec(A, B));