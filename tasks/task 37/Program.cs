int[] massive= new int[123];
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
void massive_number_counter_from_10_till_100(int[] dobby)
{
    int lenght=dobby.Length;
    int position=0;
    int count =0;
    while(position<lenght)
    {
        if(dobby[position]<100 & dobby[position]>10)
        {
            count++;
        }
        position++;
        
    }
    Console.WriteLine("в массиве "+ count +" чисел от 10 до 99");
}
massive_filler_from_0_till_999(massive);
mssivePrint(massive);
massive_number_counter_from_10_till_100(massive);