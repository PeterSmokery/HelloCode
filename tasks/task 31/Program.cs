int[] mass = new int[8];
void mssivePull(int[] pop)
{
    int lenght=pop.Length;
    int lon = 0;
    while (lon < lenght)
    {
        pop[lon]=new Random().Next(1,100);
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
             break;
         }
         Console.Write(",");
         order++;
     }
}
mssivePull(mass);
mssivePrint(mass);
