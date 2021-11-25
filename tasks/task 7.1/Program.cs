Console.WriteLine("введите число N");
int N =int.Parse(Console.ReadLine());

int count = 0;
while(count<N+1)
{
    if(count%2==0)
{
    Console.Write(count);
    Console.Write(",");
}
count++;
}