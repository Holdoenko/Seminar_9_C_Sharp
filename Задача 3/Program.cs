/*Задача 68: Задайте значения M и N. Напишите программу, которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
M = 28; N = 7 -> 7*/

Console.Clear();

Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Nod(m, n);
Console.WriteLine("Наибольший общий делитель: {0}", Nod(m, n));

int Nod(int m, int n)
{
    while (m != n)
    {
        if (m > n)
            m = m - n;
        else
            n = n - m;
    }
    return m;
}
