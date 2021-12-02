Console.WriteLine("введите число для преобразования");
int N = int.Parse(Console.ReadLine());
int N0=N;
int count=0;
while(N>0)
{
    N=N/2;
    count++;
}
int[] arrey = new int[count];
void number_reworker(int[] massive)
{
    int Long=massive.Length;
    int position= 0;
    while (position<Long)
    {
        massive[position]=N0%2;
        N0=N0/2;
        position++;
    }
}
void mssivePrint(int[] bob)
{
     int pop=bob.Length;
     int order=0;
     while(order<pop)
     {
         Console.Write(bob[order]);
         order++;
     }
}
void massive_changer(int[] order)
{
    int lenght=order.Length;
    int point = lenght-1;
    int position=0;
    while(position<(lenght/2))
    {
        int changer= order[position];
        order[position]=order[point];
        order[point]=changer;
        point--;
        position++;
    }
}
number_reworker(arrey);
mssivePrint(arrey);
massive_changer(arrey);
Console.WriteLine(".");
mssivePrint(arrey);