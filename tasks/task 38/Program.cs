int N = new Random().Next(1,100);
int[] massive= new int[N];
void massive_filler_from_0_till_999 (int[] arrey)
{
    int lenght = arrey.Length;
    int position= 0;
    while(position<lenght)
    {
     arrey[position]=new Random().Next(0,1000);
     position++;
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
void massive_sum_counter_from_nechet_position(int[] dobby)
{
    int lenght=dobby.Length;
    int position=0;
    int sum =0;
    while(position<lenght)
    {
        if(position%2==0)
        {

           sum= sum + dobby[position];
        }
        position++;
        
    }
    Console.WriteLine("в массиве сумма чисел на нечётной позиции равна  "+ sum );
}
massive_filler_from_0_till_999(massive);
mssivePrint(massive);
massive_sum_counter_from_nechet_position(massive);