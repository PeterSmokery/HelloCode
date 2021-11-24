Console.WriteLine("введите трёхзначное число :");
int Number = int.Parse(Console.ReadLine());
Console.WriteLine("введите делитель числа :");
int Delit = int.Parse(Console.ReadLine());
int div = Number%Delit;
if(Number%Delit==0)
{Console.Write("число кратно ");
Console.Write(Delit);
}
else
{   Console.Write("число не кратно и остаток от деления равен:");
    Console.Write(div);
}