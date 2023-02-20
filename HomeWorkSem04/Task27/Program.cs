// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SymbolsCount(int N)
{
    int i = 0;
    if (N != 0)
    {
        while (N > 0)
        {
            N = N / 10;
            i++;
        }
    }
    else i = 1;
    return i;
}

int number = ReadInt("Введите число: ");
double s = 0;
for (int i = 1; i <= SymbolsCount(number); i++)
{
    s = Math.Truncate(s + number % Math.Pow(10, i) / Math.Pow(10, i - 1));
}
Console.WriteLine($"Сумма цифр в числе {s}.");