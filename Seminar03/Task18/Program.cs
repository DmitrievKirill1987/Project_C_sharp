// Программа по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

if(quarter == 1)
{
    Console.WriteLine("X > 0 Y > 0");
}
else if (quarter == 2)
{
    Console.WriteLine("X < 0 Y > 0");
}
else if (quarter == 3)
{
    Console.WriteLine("X < 0 Y < 0");
}
else if (quarter == 4)
{
    Console.WriteLine("X > 0 Y < 0");
}
else
{
    Console.WriteLine("Четверть не выбрана");
}