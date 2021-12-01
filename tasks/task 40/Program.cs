int N = new Random().Next(1,10);
double[] massive= new double[N];
void massive_filler_from_real (double[] arrey)
{
    int lenght = arrey.Length;
    int position= 0;
    while(position<lenght)
    {
     arrey[position]=new Random().NextDouble();

     position++;
    }
}
void mssivePrint(double[] arrey)
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
         Console.Write(" ; ");
         order++;
     }
}
void massive_difference_with_MinMax_finder(double[] dobby)
{
    int lenght = dobby.Length;
    int position= 0;
    double difference = 0;
    double max= dobby[position];
    double min= dobby[position];
    while(position<lenght)
    {
     if(dobby[position]>max)
     {
         max= dobby[position];
     }
     else if (dobby[position]<min)
     {
         min = dobby[position];
     }
    position++;
    }
    difference = max - min;
    Console.WriteLine("разнциа между максимальным "+max + " и минимальным "+ min+" элементами равна "+ difference);
}
massive_filler_from_real(massive);
mssivePrint(massive);
massive_difference_with_MinMax_finder(massive);