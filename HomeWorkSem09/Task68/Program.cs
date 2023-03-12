// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int M = ReadInt("Введите число M: ");
int N = ReadInt("Введите число N: ");
if (M >= 0 && N >= 0) Console.WriteLine($"Функция Аккермана для чисел {M} и {N}: {Ackermann(M, N)}");
else Console.WriteLine("Числа должны быть неотрицательные.");