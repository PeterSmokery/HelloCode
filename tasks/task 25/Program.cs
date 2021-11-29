Console.WriteLine("введите число A ");
int A = int.Parse(Console.ReadLine());
int count = 0;
int sum = 0;
while(count<A)
{
    count++;
    sum = sum + count;
}
Console.WriteLine(sum);