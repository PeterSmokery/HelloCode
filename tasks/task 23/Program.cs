Console.WriteLine("введите число N:");
int N =int.Parse(Console.ReadLine());
int count = 1;
while (count-1<N)
{
    Console.Write("число ");
    Console.Write(count);
    Console.Write(" в квадрате равно = ");
    Console.Write(Math.Pow(count,2));
    Console.Write(",");
    count++;
}