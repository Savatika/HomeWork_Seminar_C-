// нахождение максимального из двух чисел
Console.WriteLine("Введите два числа");
int.TryParse (Console.ReadLine(), out int a);
int.TryParse (Console.ReadLine(), out int b);
if (a < b) 
{
Console.Write("max = ");
Console.WriteLine(b);
}
else if (a > b) 
{
Console.Write("max = ");
Console.WriteLine(a);
}
else
{
    Console.WriteLine("Числа равны");
}
