// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов от 1 до N.

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if(N > 0)
{
    for(int i = 1; i <= N; i++)
    {
        Console.Write($"{Math.Pow(i, 3)}, ");
    }
}
else
{
    Console.Write("Введено неверное значение !)");
}
Console.WriteLine();