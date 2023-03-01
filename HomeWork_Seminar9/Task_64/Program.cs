// Вывсети числа от N до 1

Console.Write("Введите число:");
int N = int.Parse(Console.ReadLine());

string NumbersRec(int a)
{
 if (a > 1) return $"{a}, " + NumbersRec(a - 1);
 else return "1";
}
Console.WriteLine(NumbersRec(N));
