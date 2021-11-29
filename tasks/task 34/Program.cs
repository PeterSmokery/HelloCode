Console.WriteLine("введите число:");
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
     while(position<N)
     {
         order[position]=order[lenght];
         Console.WriteLine
         position++;
         lenght--;
     }
}
massive_filler(massive);
mssivePrint(massive);
massive_order_changer(massive);