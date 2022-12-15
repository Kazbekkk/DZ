Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int d = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int b = Convert.ToInt32(Console.ReadLine());

if (a < d)
{
    if (b < d)
    {
        Console.WriteLine($"Максимальное число {d}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {b}");
    }
}
else
{
    if (b < a)
    {
        Console.WriteLine($"Максимальное число {a}");
    }
    else
    {
        Console.WriteLine($"Максимальное число {b}");
    }
}