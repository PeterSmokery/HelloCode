Console.WriteLine("введите число N:");
int N =int.Parse(Console.ReadLine());
int N0=N;
if (N>0)
{
while (N>0)
{
    Console.Write("-");
    Console.Write(N);
    Console.Write(",");
    N=N-1;
}
while (N!=N0)
{Console.Write(N);
Console.Write(",");
N=N+1;}
Console.Write(N0);
}
if (N<0)
{while(N<0)
{
    Console.Write(N);
    Console.Write(",");
    N=N+1;
}
while(N!=-N0)
{Console.Write(N);
Console.Write(",");
N=N+1;}
Console.Write(N);
}