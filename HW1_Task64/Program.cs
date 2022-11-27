// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();

Console.WriteLine("Please enter first number:");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1) Console.WriteLine("The first number must be greater than 1!");
else Shownumbers(n);

void Shownumbers(int n)
{
    Console.Write($"{n} ");
    if (n == 1) return;
    Shownumbers(n - 1);
}