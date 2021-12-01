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
void massive_par_multiplication(int[] dobby)
{
    int lenght = dobby.Length;
    int position= 0;
    int multiplication = 0;
    while(position<(N/2))
    {
     multiplication= dobby[position]*dobby[lenght-1];
     Console.WriteLine( "произведение равно " +multiplication+ " от " +(position+1) + "пары");
     position++;
     lenght--;
    }

}
massive_filler_from_0_till_999(massive);
mssivePrint(massive);
massive_par_multiplication(massive);