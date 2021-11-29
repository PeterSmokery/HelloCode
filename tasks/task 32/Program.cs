int[] mass = new int[8];
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
mssivePrint(mass);

