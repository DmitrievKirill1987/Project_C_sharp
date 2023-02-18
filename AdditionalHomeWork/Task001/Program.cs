// Написать программу по нахождению факториала числа N

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int A = 1;
if (N < 0)
{
    Console.WriteLine("Факториала отрицательного числа не существует");
}
else if (N == 0)
{
    Console.WriteLine("Факториал нуля равен 1");
}
else
{
    while (i <= N)
    {
        A = A * i; 
        i++;
    }
    Console.WriteLine($"Факториал числа N равен {A} ");
}