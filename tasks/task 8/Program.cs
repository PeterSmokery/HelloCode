Console.WriteLine("введите число N:");
int N = int.Parse(Console.ReadLine());
int count = 1;
while (count != N)
{Console.Write(count);
Console.Write(",");
count=count+1;
}
Console.Write(count);