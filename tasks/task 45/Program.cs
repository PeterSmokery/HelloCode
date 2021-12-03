Console.WriteLine("введите сколько чисел фиббоначи вы хотите увидеть:");
int N =int.Parse(Console.ReadLine());
int[] arrey = new int[N];
int length = arrey.Length;
int count =0;
while (count<length)
{
  if ((count==1)|(count==0))
  {
      arrey[count]=1;
  }
  else
  {
      arrey[count]=arrey[count-1]+arrey[count-2];
  }
  Console.Write(arrey[count]+",");
   count++;
}