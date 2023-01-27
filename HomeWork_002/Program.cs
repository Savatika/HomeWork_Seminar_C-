int.TryParse (Console.ReadLine(), out int a);
int.TryParse (Console.ReadLine(), out int b);
int.TryParse (Console.ReadLine(), out int c);
if ((a < b) & (b < c) | (b < a) & (a < c))
{
Console.Write("max = ");
Console.WriteLine(c);
}

else if ((a < c) & (c < b) | (c < a) & (a < b))
{
Console.Write("max = ");
Console.WriteLine(b);
}

else if ((c < b) & (b < a) | (b < c) & (c < a))
{
Console.Write("max = ");
Console.WriteLine(a);
}

else
{
    Console.WriteLine("Числа равны");
}
