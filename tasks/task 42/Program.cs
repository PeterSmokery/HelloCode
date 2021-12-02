void keybord_number_reader(int kolvo)
{
int try_s = 0;
int count = 0;
while(try_s < kolvo )
{
Console.WriteLine("введите число: ");
int number=int.Parse(Console.ReadLine());
if (number>0)
{
    count++;
}
try_s++;
}
if (count==1)
{
    Console.WriteLine("с клавиатуры введено одно число больше нуля");
}
else if (count>5)
{
    Console.WriteLine("с клавиатуры введено : "+count+ " чисел больше 0");
}
else if ((count<5)&&(count>1))
{
    Console.WriteLine("с клавиатуры введено "+count+" числа больше 0");
}
else
{
    Console.WriteLine("с клавиатуры не введено ни одного числа больше 0");
}
}
Console.WriteLine("введите ,сколько чисел вы хотите набрать с клавиатуры");
int N = int.Parse(Console.ReadLine());
keybord_number_reader(N);
