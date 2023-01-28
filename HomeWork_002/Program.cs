// нахождение максимального из трех чисел
Console.WriteLine("Введите три числа");
int.TryParse (Console.ReadLine(), out int a);
int.TryParse (Console.ReadLine(), out int b);
int.TryParse (Console.ReadLine(), out int c);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);