Console.WriteLine("введите число N:");
int N =int.Parse(Console.ReadLine());
int count = 1;
while (count-1<N)
{
    Console.Write(Math.Pow(count,2));
    Console.Write(",");
    count++;
}