Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine());
if(N<0)
{
    N=N*(-1);
}
int N0 = N;
int Count_cifr = 0;
while(N!=0)
{
    N = N/10;
    Count_cifr++;
}
if (Count_cifr<3)
{
    Console.WriteLine("число не подходит");
}
else 
{
    while(Count_cifr>3)
    {
        N0=N0/10;
        Count_cifr--;
    }
   Console.WriteLine(N0%10);
}