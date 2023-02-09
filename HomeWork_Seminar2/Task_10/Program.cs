// Найти вторую цифру числа
Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine(), out int N);
Console.WriteLine((N/10)%10);

