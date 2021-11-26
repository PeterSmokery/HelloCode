Console.WriteLine("введите координату X:");
int X =int.Parse(Console.ReadLine());
Console.WriteLine("введите координату Y:");
int Y =int.Parse(Console.ReadLine());
if ((X>0)&(Y>0))
{
    Console.WriteLine("точка находится в 1-ой четверти");
}
if ((X>0)&(Y<0))
{
     Console.WriteLine("точка находится в 4-ой четверти");
}
if ((X<0)&(Y<0))
{
     Console.WriteLine("точка находится в 3-ой четверти");
}
if ((X<0)&(Y>0))
{
     Console.WriteLine("точка находится в 2-ой четверти");
}