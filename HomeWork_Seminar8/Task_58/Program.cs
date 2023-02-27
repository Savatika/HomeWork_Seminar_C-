// Умножение матриц
Console.WriteLine("Введите размеры 1-й матрицы: ");
Console.Write("Количество строк: ");
int a_1 = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов: ");
int b_1 = int.Parse(Console.ReadLine());
int [,] matrix_1 = new int [a_1, b_1];

Console.WriteLine("Введите размеры 2-й матрицы: ");
Console.Write("Количество строк: ");
int a_2 = int.Parse(Console.ReadLine());
Console.Write("Количество столбцов: ");
int b_2 = int.Parse(Console.ReadLine());
int [,] matrix_2 = new int [a_2, b_2];

FillArray(matrix_1);
PrintArray(matrix_1);

Console.WriteLine();

FillArray(matrix_2);
PrintArray(matrix_2);

PrintArray(ProductMatrices(matrix_1, matrix_2));



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
            matrix[i, j] = random.Next(1, 10);
        }
    }
}


 int [,] ProductMatrices(int [,] arr_1, int [,] arr_2)
 {
    if (arr_1.GetLength(1) != arr_2.GetLength(0))
    {
        Console.WriteLine("Данные матрицы нельзя перемножить!!!");
        return null;
    }
        int[,] arr_3 = new int[arr_1.GetLength(0), arr_2.GetLength(1)];
        for (int i = 0; i < arr_1.GetLength(0); i++)
        {
            for (int j = 0; j < arr_2.GetLength(1); j++)
            {
                for (int x = 0; x < arr_2.GetLength(0); x++)
                {
                    arr_3[i,j] += arr_1[i,x] * arr_2[x,j];
                }
            }
        }
        return arr_3;
 }

