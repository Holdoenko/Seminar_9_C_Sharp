
/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.Clear();

Console.Write("Введите начальное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

FillArray(m, n, 0);

void FillArray (int m, int n, int sum)
{
    if (m > n) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (m++);
    FillArray(m, n, sum);
}