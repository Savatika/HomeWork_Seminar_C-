//Вывод четных чисел 
Console.WriteLine("Введите число");
int.TryParse(Console.ReadLine(), out int N);
int count = 0;
if (N > 2)
{
    while (count < (N-1))
    {
        count+= 2;
        Console.Write(count + " ");
    }
}
else Console.WriteLine("Маленькое число");