// Вывести разницу между минимальным и максимальным значением массива
int [] array = new int [5];
creationArray(array);
Console.WriteLine(string.Join(" ", array));
Console.WriteLine($"Разница равна - {diffMaxMin(array)}");

void creationArray(int [] array)
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    array[i] = random.Next(1, 100);
}

int diffMaxMin(int [] array)
{
    int diff = 0;
    int min = array[0];
    int max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
        else if(max < array[i])
        {
            max = array[i];
        }
    }
    diff = max - min;
    return diff;
}