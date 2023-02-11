// Цикл принимает числа A и B и выводит A в степени В
int A = 4;
int B = 3;
int exponentiation(int footing, int indicator) // функция возведения в степень
{
    int count = 0;
    int summ = 1;
    while (count < indicator)
    {
        summ = summ * footing;
        count++;
    }
    return summ;
}

Console.WriteLine(exponentiation(A, B));