// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine(), out int N);
Console.WriteLine((N/10)%10);

