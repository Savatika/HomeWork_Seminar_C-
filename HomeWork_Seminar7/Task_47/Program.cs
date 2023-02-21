// массив заполенный случайными вещественными числами
Console.WriteLine("Введите количество столбцов");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите количество строк");
int n = int.Parse(Console.ReadLine());

double [,] matrix = new double[n ,m];

void printMatrix(double [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
    
}

double [,] fillArray(double [,] array)
{
    Random random = new Random();
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            matrix[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
        
    }
    return matrix;
}

printMatrix(matrix);
fillArray(matrix);
Console.WriteLine();
printMatrix(matrix);