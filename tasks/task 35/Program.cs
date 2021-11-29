int N = new Random().Next(1,30);
int[] massive= new int[N];
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
void number_finder(int[] arrey)
{
    Console.WriteLine("введите число K для поиска:");
    int K =int.Parse(Console.ReadLine());
    int position=0;
    int order=arrey.Length;
    int point=0;
    while(position<order)
    {
        if(arrey[position]==K)
        {
            point++;
        }
        position++;
    }
    if(point==0)
    {
        Console.WriteLine("нет подходящего числа");
    }
    else
    {
        Console.WriteLine("число "+K+" присутствует в массиве "+point+" раз/a");
    }
}
massive_filler (massive);
mssivePrint(massive);
number_finder(massive);
