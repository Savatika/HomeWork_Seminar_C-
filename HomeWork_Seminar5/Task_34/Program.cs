// Создать массив из случайных чисел и вывести количество четных чисел

Console.WriteLine("Введите количество чисел в массиве");
int length = int.Parse(Console.ReadLine());
Console.WriteLine(summEvenNumbers(creationArroy(length)));

int [] creationArroy(int length) // создание массива (количество элементов указывается пользователем)
{
    int [] array = new int [length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 999);
    }
    return array;
 }

int summEvenNumbers(int[] array) // находит количество четных элементов
{
    int summ = 0;
    for (int y = 0; y < array.Length; y++) // вывод значений массива для проверки
    {
        Console.Write(array[y] + " ");
    }

    Console.WriteLine();

    for (int i = 0; i < array.Length; i++) // определение четных чисел
    {
        int index = array[i] % 2;
        if (index != 0); // не знаю насколько правильно делать пустой if (вылезала ошибка что не получилось неявно пеобразить int  в bool)
        else
        {
            summ++;
        }
        
    }
    return summ;
}

