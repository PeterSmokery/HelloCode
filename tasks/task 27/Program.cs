Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine());
int Count_cifr = 0;
while(N!=0)
{
    N = N/10;
    Count_cifr++;
}
Console.WriteLine(Count_cifr);