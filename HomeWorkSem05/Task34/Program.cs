//  Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
//  [345, 897, 568, 234] -> 2

int ArrLong(string text)
{
    Console.Write(text);
    return Math.Abs(Convert.ToInt32(Console.ReadLine()));
}

void GenArr(int[] array, int leftRange, int rightRange)
{
    for (int i = 0; i < array.Length; i++)
    {
        Random rand = new Random();
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
}

void PrintArr(int[] array)
{
    Console.WriteLine("[" + string.Join(",", array) + "]");
}

int CountNumb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int[] arr = new int[ArrLong("Введите длину массива: ")];
GenArr(arr, 100, 999);
PrintArr(arr);
Console.WriteLine($"Количество четных чисел в массиве: {CountNumb(arr)}");