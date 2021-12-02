Console.WriteLine("введите длинну массива:");
int N = int.Parse(Console.ReadLine());
int[] massive = new int[N];
void massive_filler (int[] arrey)
{
    int lenght = arrey.Length;
    int position= 0;
    while(position<lenght)
    {
     arrey[position]=new Random().Next(1,100);
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
void massive_order_changer(int[] order)
{
     int lenght=order.Length;
     int position=0;
     int end=order[0];
     int last_number=order[lenght-1];
     while(position<N-1)
     {
         order[position]=order[lenght-1];
         Console.Write(order[position]);
         Console.Write(",");
         position++;
         lenght--;
     }
     Console.Write(end);
}
massive_filler(massive);
mssivePrint(massive);
massive_order_changer(massive);