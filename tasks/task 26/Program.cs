Console.WriteLine("введите число N :");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("введите степень A для возведения");
int A = int.Parse(Console.ReadLine());
int count = 0;
int result = 1 ;
while(count<A)
{
    count++;
    result= result * N ;
}
Console.WriteLine(result);

