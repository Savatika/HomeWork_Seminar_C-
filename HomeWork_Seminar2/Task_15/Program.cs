// найти выходной день
Console.WriteLine("Введите число от 1 до 7");
int.TryParse (Console.ReadLine(), out int N);
if ((N == 6) | (N == 7))
{
    Console.WriteLine("Это выходной, УРААА!!!!");
}
else 
{
    Console.WriteLine("Это не выходной день, держись.");
}
