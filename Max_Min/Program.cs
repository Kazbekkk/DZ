Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число:");
int d = Convert.ToInt32(Console.ReadLine());

if (a < d)
{
    Console.WriteLine($"Максимальное число {d}, Минимальное {a}");
}
else
{
    Console.WriteLine($"Максимальное число {a}, Минимальное {d}");
}