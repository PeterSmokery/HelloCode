Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine());
if (N%2==0)
{
    Console.Write(Math.Pow(N,3));
}
else
{
    Console.Write("число заканчивается на нечётную цифру");
}