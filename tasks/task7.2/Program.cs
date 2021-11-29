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
      Console.Write(order[position]);
        if(position+1==lenght)
        {
            Console.Write(" ура мы справились ! ");
            break;
        }
        Console.Write(',');
      otric_N++; 
      position++;
    }
}

int[] N_World = new int[2*N+1];
N_World_fill(N_World);
