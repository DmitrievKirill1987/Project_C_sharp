//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом

Console.Write("Введите число: ");
int N = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] arrN = new int[5];
arrN [0] = N/10000;
arrN [1] = (N/1000) %10;
arrN [2] = (N/100)%10;
arrN [3] = (N/10)%10;
arrN [4] = N%10;
if(N > 9999 && N < 100000)
{
if( arrN [0] == arrN [4] && arrN [1]== arrN [3])
{
    Console.WriteLine("N полиндромное число");
}
else
{
   Console.WriteLine("N не полиндромное число");
} 
}
else{
    Console.WriteLine("Число не является пятизначным!");
}