// программа задает массив из восьми элементов и выводит на экран (в примере массивы не из 8 элементов)
int [] array = creationArray(ReadInt("number 8"));

int ReadInt(string argumentNumber)
{
    Console.WriteLine($"Input {argumentNumber}: ");
    int number = 0;
    while(!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It'a not a number");
    }
    return number;
}

int[] creationArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();

    for (int counter = 0; counter < length; counter++)
    {
        array[counter] = random.Next(0, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int counter = 0; counter < array.Length - 1; counter++)
    {
        Console.Write($"{array[counter]}, ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.WriteLine("]");
}

PrintArray(array);