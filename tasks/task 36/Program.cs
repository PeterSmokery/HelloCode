int N = new Random().Next(1,30);
int[] massive= new int[N];
void massive_filler_from_100_till_999 (int[] arrey)
{
    int lenght = arrey.Length;
    int position= 0;
    while(position<lenght)
    {
     arrey[position]=new Random().Next(100,1000);
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
void massive_number_counter(int[] dobby)
{
    int lenght=dobby.Length;
    int position=0;
    int chet_count=0;
    int nechet_count=0;
    while(position<lenght)
    {
        if(dobby[position]%2==0)
        {
            chet_count++;
        }
        else
        {
            nechet_count++;
        }
        position++;
    }
    Console.WriteLine("в массиве "+chet_count+" чётных и " + nechet_count+" нечётных чисел");
}
massive_filler_from_100_till_999(massive);
mssivePrint(massive);
massive_number_counter(massive);