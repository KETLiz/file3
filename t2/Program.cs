// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("a - максимальное число");
    }
    else
    {
        Console.WriteLine("c - максимальное число");
    }
}
else
{
    if (b > c)
    {
    Console.WriteLine("b - максимальное число");
    }
    else
    {
        Console.WriteLine("c - максимальное число");
    }
}