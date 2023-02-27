// вывести строку с наименьшей суммой элементов

FillArray(arr);
int minLine = MinLinesArray(arr) + 1;
PrintArray(arr);
Console.WriteLine();
Console.WriteLine($"{minLine}-я строка с наименьшей суммой элементов");

void PrintArray(int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

void FillArray(int[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix [i, j] = random.Next(1, 10);
        }
    }
}

int  MinLinesArray(int [,] matrix)
{
    int[] index = new int [matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {   
            sum = sum + matrix[i, j];
        }
        index[i] = sum;
    }
    return MinNumberArray(index);
}

int MinNumberArray(int [] array)
{
    int min = array[0];
    int indexMin = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
            indexMin = i;
        }
    }
    return indexMin;
}

int [,] arr = new int [3, 5];



