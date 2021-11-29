Console.WriteLine("введите число:");
int N = int.Parse(Console.ReadLine());
int proizv = 1;
int count = 0;
while(count<N)
{
    count++;
    proizv = proizv *  count;
}
Console.WriteLine(proizv);


