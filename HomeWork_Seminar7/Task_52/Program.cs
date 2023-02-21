// среднее арифметическое каждого столбца
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine());

int [,] matrix = new int [row, column];

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
            array [i, j] = random.Next(1, 10);
        }
    }
}

double [] StrintArithmeticMean(int [,] matrix, int row)
{
    double [] ArithmeticMean = new double [column];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        ArithmeticMean[j] = Math.Round((double)sum / row, 2);
    }
    return ArithmeticMean;
}

FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
Console.WriteLine();
double [] array = StrintArithmeticMean(matrix, row);
Console.Write("Среднее арифметическое каждого столбца: ");
Console.WriteLine(string.Join("; ", array));