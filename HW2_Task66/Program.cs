// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();

Console.WriteLine("Please enter first number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter last number:");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    Console.WriteLine("The first and last numbers have been switched:");
    Console.Write($"{n}, {m} ->");
    SumBetweenNumbers(n, m, 0);
}

else
{
    Console.Write($"{m}, {n} ->");
    SumBetweenNumbers(m, n, 0);
}

void SumBetweenNumbers(int start, int end, int sum)
{
    sum += end;
    if (end <= start)
    {
        Console.Write($" {sum} ");
        return;
    }
    SumBetweenNumbers(start, end - 1, sum);
}

