// Программа принимает число Н и выдает произведение от 1 до Н

int ReadInt(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Factorial(int A)
{
    int sum = 1;
    //добавить ругательства на -
    for (int i = 2; i <= A; i++)
    {
        sum *= i;
    }
    return sum;
}

Console.WriteLine($"Произведение чисел = {Factorial(ReadInt("Введите число N: "))}.");