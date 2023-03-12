// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumber(int m, int n)
{
    if (n == m) return n;
    return n + SumNumber(m, n - 1);
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M < N) Console.WriteLine($"Сумма чисел от {M} до {N}: {SumNumber(M, N)}");
else Console.WriteLine($"Сумма чисел от {N} до {M}: {SumNumber(N, M)}");