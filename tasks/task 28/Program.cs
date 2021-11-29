Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine());
int sum = 0;
while(N>0)
{
  sum = sum + N%10;
  N=N/10;
}
Console.Write(sum);
