//Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool X = true;
bool y = true;
bool Z = !(X && y)==!(X|!y);
if(Z==false)
{
    Console.WriteLine("увтреждение ложно ");
}
else
{
    Console.WriteLine("утверждение истино");
}