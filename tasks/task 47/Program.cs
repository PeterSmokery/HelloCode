int[] arrey ={1,3,4,5,-3,2,8,4,8};
void arrey_copy(int[] massive)
{
    int N = arrey.Length;
    int[] dude = new int[N];
    int count =0;
    while(count<N)
    {
        dude[count]=arrey[count];
        Console.Write(dude[count]);
        if (count+1==N)
        {
            break;
        }
        Console.Write(",");
        count++;
    }

}
arrey_copy(arrey);