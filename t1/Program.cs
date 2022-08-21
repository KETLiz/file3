// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("a - максимальное число");
}
else
{
    Console.WriteLine("b - максимальное число");
}