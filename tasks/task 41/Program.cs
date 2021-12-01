Console.Write("введите число A : ");
int A = int.Parse(Console.ReadLine());
Console.Write("введите число B:");
int B = int.Parse(Console.ReadLine());
Console.Write("введите число C: ");
int C = int.Parse(Console.ReadLine());
if ((A>=B+C) | (B>=A+C) | (C>=A+B))
{
    Console.WriteLine("не,это точно не стороны треугольника");
}
else
{
     Console.WriteLine("о да ,это треугольник !и он кстати ...");
     if ((A==B)& (B==C))
     {
          Console.Write("равносторонний !");
     }
     else if ((A==B)^(B==C)^(A==C))
     {
          Console.Write(" равнобедренный !");
     }
     else
     {
          Console.Write(" ну обычный такой ,нормальный");
     }
} 
