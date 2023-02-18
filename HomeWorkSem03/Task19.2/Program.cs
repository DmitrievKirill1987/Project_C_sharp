//Проверка на палиндромность с применением строчного типа данных

Console.Write("Введите число: ");
string? N = Console.ReadLine();
char[] arrN = N.ToCharArray();
bool result = false;
 
for(int i = 0; i <= (arrN.Length / 2); i++)
{
    if(arrN[i] == arrN[arrN.Length - 1 - i])
    {
        result = true;
    }
    else
    {
        break;
    }
}
 
if(result == true)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}
