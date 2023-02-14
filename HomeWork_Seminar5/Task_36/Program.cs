// Вычислить сумму чсел стоящих на нечетных позициях массива
int [] array = new int [9];
creationArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Сумма чисел на нечетных позициях равна - {summNumber(array)}");
void creationArray(int [] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 10);
    }
}

int summNumber(int [] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i%2 == 1)
        {
            summ += array[i];
        }
    }
    return summ;
}
