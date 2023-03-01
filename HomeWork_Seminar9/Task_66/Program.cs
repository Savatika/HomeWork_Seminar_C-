// Сумма чисел от n до b
Console.Write("Введите число от которго будет считаться сумма чисел: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число до которго будет считаться сумма чисел: ");
int b = int.Parse(Console.ReadLine());

int SumRec(int n, int b)
{
 if (b < n) return 0;
 else return b + SumRec(n, b - 1);
}

Console.WriteLine($"Сумма чисел от {n} до {b} = {SumRec(n, b)}");
