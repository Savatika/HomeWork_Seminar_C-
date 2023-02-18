// сколько чисел больше нуля ввел пользоваетль

Console.WriteLine("Сколько чисел вы хотите ввести?");

int length = int.Parse(Console.ReadLine());

Console.WriteLine("Введите числа");

int [] array = creationArray(length);
int summ = sumPosNumber(array);

Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Количество положительных чисел - {summ}");

int [] creationArray(int length)
{
    int [] arr = new int[length];
    for(int i = 0; i < length; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int sumPosNumber(int [] arr)
{
    int summ = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] >= 0)
        {
            summ++;
        }
    }
    return summ;
}






























// int summDig(int number)
// {
//     bool c = true;
//     int summ = 0;
//     while(c)
//     {
//         int num = ReadInt("number");
//         if (num > 0)
//         {
//             summ++;
//         }
//         else if (num == 0000)
//         {
//             c = false;
//         }
//     }
//     return summ;
// }

