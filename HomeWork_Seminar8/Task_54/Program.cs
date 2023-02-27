// Сортировка строк матрицы от большего к меньшему

int [,] matrix = new int [4, 5];
FillArray(matrix); // заполняем матрицу (рандом)
PrintArray(matrix); // выводим матрицу
SortedArray(matrix); // сортируем строки матрицы
PrintArray(matrix); // выводим отсортированную матрицу


void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array [i, j]} ");
        }
        Console.WriteLine();
    }
}

int [,] FillArray(int [,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = random.Next(1, 10);
        }
    }  
    return array; 
}

void SortedArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1) - 1; x++)
            {
                if (array[i, x] < array[i, x+1])
                {
                    int max = array[i, x+1];
                    array [i, x+1] = array[i, x];
                    array[i, x] = max;
                }
            }
        }
    }
}



