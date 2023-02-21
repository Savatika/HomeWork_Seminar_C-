// Нахождение элемента двумерного массива по введенному числу
Console.Write("Введите двузначное число: ");
int coordinates = int.Parse(Console.ReadLine());
int column = coordinates / 10;
int row = coordinates%10;
int [,] matrix = new int[6, 5];

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            matrix [i, j] = random.Next(1, 10);
        }
    }
}

void NumberSearch(int [,] matrix, int column, int row)
{
    if (column <= matrix.GetLength(0) & row <= matrix.GetLength(1))
    {
        Console.Write("Число по указанным координатам - ");
        Console.WriteLine(matrix[column, row]);
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");   
    }
}

Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
NumberSearch(matrix, column - 1, row - 1);
