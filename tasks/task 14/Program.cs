Console.WriteLine("введите  число :");
int Number = int.Parse(Console.ReadLine());
if ((Number/100)%10!=0)
{
        Console.WriteLine((Number/100)%10);
}

if(Number/1000!=0)
{
Console.WriteLine((Number/100)%10);
}
else
{
Console.WriteLine("у числа нет третьей цифры");
}
