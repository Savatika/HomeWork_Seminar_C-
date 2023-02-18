// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int k1 = int.Parse(Console.ReadLine());
int k2 = int.Parse(Console.ReadLine());
int b1 = int.Parse(Console.ReadLine());
int b2 = int.Parse(Console.ReadLine());

double deltaK = k2 - k1;
double deltaB = b2 - b1;
double x = (-1) * (deltaB/deltaK);

double y = k1 * x + b1;

Console.WriteLine($"Точка пересечения прямых - ({x}, {y})");
