// найти 3 цифру числа
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int N);
if (N>=100)
{
    while (N>999)
    {
        N = N/10;
    }
    Console.WriteLine(N % 10);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
