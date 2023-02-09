int count = 0;
int dis = 10000;
int ffs = 1;
int sfs = 2;
int ds = 5;
int f = 2;
int t = 0;

while (dis > 10)
{
    if (f == 1)
    {
        t = dis / (ffs + ds);
        f = 2;
    }
    else
    {
        t = dis / (sfs + ds);
        f = 1;
    }
    dis = dis - (ffs + sfs) * t;
    count = count + 1;
}

Console.WriteLine(count);
