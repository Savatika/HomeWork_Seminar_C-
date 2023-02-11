// Нахождение суммы цифр числа
int ReadInt(string argumentName)
{
    Console.WriteLine($"Input {argumentName}");

    int number = 0;
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number");
    }
    return number;
}


int SumDigital(int Number) 
{
    int summ = 0;
    while (Number > 0)
    {
        summ = summ + (Number % 10);
        Number = Number / 10;
    }
    return summ;
}

Console.WriteLine(SumDigital(ReadInt("number")));
