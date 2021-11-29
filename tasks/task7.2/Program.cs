Console.WriteLine("введите число N: ");
int N =int.Parse(Console.ReadLine());
int otric_N = -N;
void N_World_fill(int[] order)
{
    int lenght= order.Length;
    int position = 0;
    while (position < lenght )
    {
      order[position] = otric_N;
      otric_N++; 
      position++;
    }
}
void N_World_print(int[]array)
{
    int order =array.Length;
    int pool = 0;
    while (pool< order)
    {
        Console.Write(array[pool]);
        if(pool+1==order)
        {
            break;
        }
        Console.Write(',');
        pool++;
    
    }
}
int[] N_World = new int[2*N+1];
N_World_fill(N_World);
N_World_print(N_World);

