// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int A = ReadInt("Число А: ");
int B = ReadInt("Число B: ");
Console.WriteLine($"Число А в степени B = {Math.Pow(A, B)}.");