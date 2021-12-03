Console.WriteLine("введите количество вершин у фигруы:");
int N=int.Parse(Console.ReadLine());
double[] massive = new double[2*N];
int count =0;
int number =1;
while(count<2*N)
{
    if(count%2==0)
    {
        Console.WriteLine("введите координату x "+number+ " вершины:");
        massive[count]=double.Parse(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("введите координату y "+number+ " вершины:");
        massive[count]=double.Parse(Console.ReadLine());
        number++;
    }
    count++;
}
void mssivePrint(double[] arrey)
{
     int pop=arrey.Length;
     int order=0;
     while(order<pop)
     {
         if(order%2==0)
         {
            Console.Write("( "+arrey[order]+";");

         }
         else
         {
             Console.Write(arrey[order]+" ) " );
             if (order+1==pop)
             {
                 Console.WriteLine(".");
                 break;
             }
             Console.Write(",");
         }
         
         order++;
     }
}
mssivePrint(massive);
void massive_mashtab(double[] massive)
{
    Console.WriteLine("введите коофициент масштабирования: ");
    double K =double.Parse(Console.ReadLine());
    int length=massive.Length;
    int count =0;
    while (count<length)
    {
        massive[count]=massive[count]*K;
        count++;
    }
}
massive_mashtab(massive);
mssivePrint(massive);