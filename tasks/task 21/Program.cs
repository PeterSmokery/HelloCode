Console.WriteLine("введите пятизначное число на проверку:");
int Number =int.Parse(Console.ReadLine());
if ((Number%10==Number/10000)&(((Number/1000)%10==(Number%100)/10)))
{
    Console.WriteLine("да это же палиндром ! !  !");
}
else
{
    Console.WriteLine("не ,это не палиндром(");
}