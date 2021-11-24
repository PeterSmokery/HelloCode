Console.WriteLine("введите трёхзначное число для удаления второй цифры числа:");
int N = int.Parse(Console.ReadLine());
Console.WriteLine((N/100)*10+N%10);