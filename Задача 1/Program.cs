/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8*/

Console.Clear();

Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());
FillArray(m, n);

void FillArray(int a, int b)
{
    if (b < a) return;

    if (b % 2 == 0) FillArray(a, b - 2);
    else FillArray(a, b - 1);

    if (b % 2 == 0)
    Console.Write(b + ", ");
}
