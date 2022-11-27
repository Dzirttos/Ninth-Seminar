// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Please enter first number:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter last number:");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0) Console.WriteLine("The numbers you enter must be above 0!");
else
{
    int functionOfAkkerman = Akkerman(m, n);
    Console.Write($"For number {m} and number {n} the calculation of Akkerman function is {functionOfAkkerman} ");
}

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}




