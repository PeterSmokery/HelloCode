int[] mass = new int[12];
void mssivePull(int[] pop)
{
    int lenght=pop.Length;
    int lon = 0;
    while (lon < lenght)
    {
        pop[lon]=new Random().Next(-10,10);
        lon++;
    }
}
void mssivePrint(int[] arrey)
{
     int pop=arrey.Length;
     int order=0;
     while(order<pop)
     {
         Console.Write(arrey[order]);
         if (order+1==pop)
         {
             Console.WriteLine(".");
             break;
         }
         Console.Write(",");
         order++;
     }
}
mssivePull(mass);
mssivePrint(mass);
int plus_sum=0;
int minus_sum= 0;
int count=0;
int Length= mass.Length;
while (count<Length)
{
    if (mass[count]>0)
    {
        plus_sum= plus_sum+mass[count];
    }
    else
    {
        minus_sum=minus_sum+mass[count];
    }
    count++;
}
Console.WriteLine(" сумма положительных элементов равна ");
Console.WriteLine(plus_sum);
Console.WriteLine(" сумма отрицательных  элементов равна ");
Console.WriteLine(minus_sum);
